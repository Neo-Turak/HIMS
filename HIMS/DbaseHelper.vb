'written by:Nura

Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Module DbaseHelper
    Public Const ConStr As String = "server=.;UID=sa;PWD=root;database=ghgl"

    Public Function CheckID(ByVal ID As String) As List(Of String)
        Dim lst As New List(Of String)
        Dim cn As SqlConnection
        Dim cmd As SqlCommand
        cn = New SqlConnection(ConStr)
        cn.Open()
        cmd = New SqlCommand("select * from 用户表 where id=" + ID, cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        dr.Read()
        lst.Add(dr.Item("用户名").ToString)
        lst.Add(dr.Item("密码").ToString)
        lst.Add(dr.Item("科室").ToString)
        lst.Add(dr.Item("职位").ToString)
        dr.Close()
        cmd.Dispose()
        cn.Close()
        Return lst
    End Function

    Public Sub Store_pic_Sql(ByVal img As Image, ByVal id As String)

        'for sql server
        Dim cn As SqlConnection = New SqlConnection With {
            .ConnectionString = "Data Source=.;Initial Catalog=ghgl;Persist Security Info=True;User ID=sa;Password=root"
        }

        'for SQL
        Dim sql As String = "update 患者总表 set 相片 =@imgData where 患者编号 ='" + id + "'"
        Dim command1 As SqlCommand = New SqlCommand(sql, cn)
        Dim sqlpara As New SqlParameter("imgData", SqlDbType.Image)

        Dim mStream As MemoryStream = New MemoryStream()
        img.Save(mStream, ImageFormat.Jpeg)
        sqlpara.SqlValue = mStream.GetBuffer
        command1.Parameters.Add(sqlpara)
        cn.Open()
        command1.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Function Load_Pic_Sql(ByVal id As Integer) As Image
        'for sql server
        Dim conn As SqlConnection = New SqlConnection With {
            .ConnectionString = "Data Source=datasource;Initial Catalog=LoadTest;Persist Security Info=True;User ID=test;Password=123"
        }
        'for SQL
        Dim sql As String = "select img from picture where id = " & id
        Dim command1 As SqlCommand = New SqlCommand(sql, conn)
        conn.Open()
        Dim reader As SqlDataReader = command1.ExecuteReader
        reader.Read()
        Dim bitPic() As Byte = CType(reader.GetValue(0), Byte())
        conn.Close()
        Dim mStream As MemoryStream = New MemoryStream(bitPic)
        Dim img As Image = Image.FromStream(mStream)
        Return img

    End Function

    Public Function UseProc() As DataSet
        Dim dset As New DataSet("Tester")
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using cm As New SqlCommand("hl", cn)
                cm.CommandType = CommandType.StoredProcedure
                Dim adapter As New SqlDataAdapter(cm)
                adapter.SelectCommand.CommandTimeout = 200
                adapter.Fill(dset)
                '  DataGridView1.DataSource = dset.Tables(0).AsDataView()
            End Using
        End Using
        Return dset
    End Function

    Public Function 患者总表_14days_select() As DataSet
        Dim Dset As DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()

            Using sql As New SqlCommand("dbo.DAL_患者总表_7DaysRecord")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                Using dr As SqlDataReader = sql.ExecuteReader()
                    Dset = New DataSet("7days")
                    Dset.Load(dr, LoadOption.PreserveChanges, "7days")
                End Using
            End Using
        End Using
        Return Dset
    End Function

    Public Function 患者总表_删除(ByVal pr1 As String, ByVal pr2 As String, ByVal pr3 As String) As Boolean
        Dim value As Boolean = False
        Try
            Using cn As New SqlConnection(ConStr)
                cn.Open()
                Using sql As New SqlCommand("dbo.DAL_患者总表_Delete_row")
                    sql.CommandType = CommandType.StoredProcedure
                    sql.Connection = cn
                    sql.Parameters.AddWithValue("@param1", pr1)
                    sql.Parameters.AddWithValue("@param2", pr2)
                    sql.Parameters.AddWithValue("@param3", pr3)

                    Dim dr As SqlDataReader = sql.ExecuteReader()
                    If dr.RecordsAffected Then
                        value = True
                    End If
                    dr.Close()
                End Using
            End Using
        Catch e As SqlException
            Console.WriteLine(e.Message)
        End Try
        Return value
    End Function

    Public Function 助记码_查询(ByVal remember As String) As DataSet
        Dim dset As DataSet

        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("dbo.DAL_药品库存_助记码")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@Param1", remember)
                sql.ExecuteNonQuery()
                Dim dt As New SqlDataAdapter With {
                    .SelectCommand = sql
                }
                dset = New DataSet("助记码")
                dt.Fill(dset)
            End Using
            cn.Close()
        End Using
        Return dset
    End Function

    Public Function Get_挂号单详情() As DataSet
        Dim dset As New DataSet("挂号单")
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("SELECT * FROM 挂号单详情 ORDER BY 挂号时间")
                'sql.CommandTimeout = 300
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                Using dr As SqlDataReader = sql.ExecuteReader
                    If dr.HasRows Then
                        dset.Load(dr, 3, "挂号单")
                    End If

                End Using
            End Using
            cn.Close()
        End Using
        Return dset
    End Function

    Public Function 修改ID_患者总表() As Boolean
        Dim flag As Boolean = False
        Dim value As String
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using Sql As New SqlCommand("select top 1 患者编号,合作医疗号 from 患者总表 where 患者编号 is null order by 患者编号 ")
                Sql.Connection = cn
                Using dr As SqlDataReader = Sql.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        value = dr.GetString(1)
                        dr.Close()
                        flag = True
                        Dim decod As String = Strings.UCase(Hex(value))

                        Using qt As New SqlCommand("update 患者总表 set 患者编号='" + decod + "' where 合作医疗号='" + value + "'", cn)
                            Console.WriteLine("{0}------{1}", value, decod)
                            qt.ExecuteNonQuery()
                        End Using
                    Else
                        Console.WriteLine("结束了")
                        flag = False
                        dr.Close()
                    End If

                End Using
            End Using
            cn.Close()
        End Using
        Return flag
    End Function

    Public Function Get门诊诊断模板() As DataSet
        Dim dset As New DataSet(“门诊病历模板”)

        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("dbo.DAL_门诊病历模板_SelectCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                Using dr As SqlDataReader = sql.ExecuteReader
                    If dr.HasRows Then
                        dset.Load(dr, 1, "挂号单")
                    End If
                End Using
            End Using
            cn.Close()
        End Using
        Return dset
    End Function

    Public Function Get门诊诊断模板_查询(ByVal 诊断 As String) As DataSet
        Dim dset As New DataSet("门诊模板")
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("dbo.DAL_门诊病历模板_Select诊断Command")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue(“@parm”, 诊断.ToString)

                Using da As New SqlDataAdapter
                    da.SelectCommand = sql
                    da.Fill(dset)
                End Using
            End Using
            cn.Close()
        End Using
        Return dset
    End Function

    Public Function Get门诊病历(ByVal 患者编号 As String) As DataSet
        Dim dset As New DataSet("门诊病历")
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("dbo.DAL_门诊病历_ID_SelectCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue(“@param1”, 患者编号.ToString)

                Using da As New SqlDataAdapter
                    da.SelectCommand = sql
                    da.Fill(dset)
                End Using
            End Using
            cn.Close()
        End Using
        Return dset
    End Function

    Public Function Add_挂号单(ByVal 患者编号 As String, ByVal 结算方式 As String， ByVal 状态 As String) As Integer
        Dim val As Integer
        Using cn As New SqlConnection(ConStr)
            cn.Open()

            Using sql As New SqlCommand("dbo.DAL_挂号单_InsertCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@患者编号", 患者编号)
                sql.Parameters.AddWithValue("@结算方式", 结算方式)
                sql.Parameters.AddWithValue("@状态", 状态)
                val = sql.ExecuteNonQuery
            End Using
            cn.Close()
        End Using
        GC.Collect()
        Return val
    End Function

    Public Sub Add_门诊病历模板(ByVal 诊断 As String, ByVal 主诉 As String, 医嘱建议 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()

            Using sql As New SqlCommand("dbo.DAL_门诊病历模板_InsertCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@诊断", 诊断)
                sql.Parameters.AddWithValue("@主诉", 主诉)
                sql.Parameters.AddWithValue("@医嘱建议", 医嘱建议)
                sql.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
        GC.Collect()
    End Sub

    Public Function Get_病区名() As List(Of String)
        Dim list As New List(Of String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select 病区名 from 病区分类", cn)
                Using dr As SqlDataReader = sql.ExecuteReader
                    If dr.HasRows Then
                        Do While dr.Read
                            list.Add(dr.GetString(0))
                        Loop
                    End If
                End Using
            End Using
            cn.Close()
        End Using
        Return list
    End Function

    Public Sub Set_入院单(ByVal 患者编号 As String, ByVal 住院部 As String, ByVal 诊断 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()

            Using sql As New SqlCommand("[dbo].[DAL_住院单InsertCommand]", cn)
                sql.CommandType = CommandType.StoredProcedure
                sql.Parameters.AddWithValue("@患者编号", 患者编号)
                sql.Parameters.AddWithValue("@住院部", 住院部)
                sql.Parameters.AddWithValue("@诊断", 诊断)
                sql.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function Get_住院单_待收费() As DataSet
        Dim dset As New DataSet()
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using da As New SqlDataAdapter("SELECT 患者编号,住院部,诊断,状态 FROM 住院单 where 状态='待收费'", cn)
                da.Fill(dset)
            End Using
            cn.Close()
        End Using
        Return dset
    End Function

    Public Sub Del_住院单_待收费(ByVal 患者编号 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("delete 住院单 where 患者编号='" & 患者编号 & "' and 状态='待收费'", cn)
                sql.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function Add_门诊处方(ByVal 患者编号 As String, ByVal 药品名称 As String, ByVal 规格 As String, ByVal 数量 As Int16,
    ByVal 单位 As String, ByVal 剂量 As String, ByVal 单价 As Single, ByVal 金额 As Double, ByVal 用法 As String, ByVal 科室 As String, ByVal 医生 As String)
        Dim c As Integer
        Using cn As New SqlConnection(ConStr)
            cn.Open()

            Using sql As New SqlCommand("dbo.DAL_门诊处方_InsertCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@患者编号", 患者编号)
                sql.Parameters.AddWithValue("@药品名称", 药品名称)
                sql.Parameters.AddWithValue("@规格", 规格）
                sql.Parameters.AddWithValue("@数量”, 数量)
                sql.Parameters.AddWithValue("@单位", 单位)
                sql.Parameters.AddWithValue("@剂量", 剂量)
                sql.Parameters.AddWithValue("@单价", 单价)
                sql.Parameters.AddWithValue("@金额", 金额)
                sql.Parameters.AddWithValue("@用法", 用法)
                sql.Parameters.AddWithValue("@科室", 科室)
                sql.Parameters.AddWithValue("@医生", 医生)
                c = sql.ExecuteNonQuery
            End Using
            cn.Close()
        End Using

        Return c
    End Function

    Public Function Get_门诊处方(ByVal 患者编号 As String) As DataSet
        Get_门诊处方 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()

            Using sql As New SqlCommand("dbo.DAL_门诊处方_SelectCommand", cn)
                sql.CommandType = CommandType.StoredProcedure
                sql.Parameters.AddWithValue("@患者编号", 患者编号)
                Using da As New SqlDataAdapter
                    da.SelectCommand = sql
                    da.Fill(Get_门诊处方)
                End Using
            End Using
        End Using
    End Function

    Public Function Del_门诊处方(ByVal 患者编号 As String, ByVal 药品名称 As String, ByVal 日期 As Date, ByVal 时间 As TimeSpan) As Integer
        Dim result As Integer
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("[dbo].[DAL_门诊处方_DeleteCommand]")
                sql.Connection = cn
                sql.CommandType = CommandType.StoredProcedure
                sql.Parameters.AddWithValue("@患者编码", 患者编号)
                sql.Parameters.AddWithValue("@药品名称", 药品名称)
                sql.Parameters.AddWithValue("@日期", 日期)
                sql.Parameters.AddWithValue("@时间", 时间)
                result = sql.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
        Return result
    End Function

    Public Function Get_住院单() As DataSet
        Get_住院单 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select * from 住院单详情 where 状态='待收费'")
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                Using da As New SqlDataAdapter
                    da.SelectCommand = sql
                    da.Fill(Get_住院单)
                End Using
            End Using
            cn.Close()
        End Using
        Return Get_住院单
    End Function

    Public Sub Del_住院单(ByVal ID As Integer, 患者编号 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("DELETE 住院单 WHERE id=" & ID & " and 患者编号='" & 患者编号 & "'")
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                sql.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

End Module