'written by:Nura
'这里声明一下:DataReader.hasRows()跟Read()不能同时使用。会跳过第一个行.
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Module DbaseHelper
    Public Const ConStr As String = "server=127.0.0.1;UID=sa;PWD=root;database=ghgl;persist Security Info=True;"

    Public Function CheckID(ID As String) As List(Of String)
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

    '这个方法用于把图片存储在数据库里

    Public Sub Store_pic_Sql(img As Image, id As String)

        'for sql server
        Dim cn = New SqlConnection With {
                .ConnectionString =
                "Data Source=127.0.0.1;Initial Catalog=ghgl;Persist Security Info=True;User ID=sa;Password=root"
                }

        'for SQL
        Dim sql As String = "update 患者总表 set 相片 =@imgData where 患者编号 ='" + id + "'"
        Dim command1 = New SqlCommand(sql, cn)
        Dim sqlpara As New SqlParameter("imgData", SqlDbType.Image)

        Dim mStream = New MemoryStream()
        img.Save(mStream, ImageFormat.Jpeg)
        sqlpara.SqlValue = mStream.GetBuffer
        command1.Parameters.Add(sqlpara)
        cn.Open()
        command1.ExecuteNonQuery()
        cn.Close()
    End Sub

    '这个方法用于从数据库提取照片
    Public Function Load_Pic_Sql(id As Integer) As Image
        'for sql server
        Dim conn = New SqlConnection With {
                .ConnectionString =
                "Data Source=datasource;Initial Catalog=LoadTest;Persist Security Info=True;User ID=test;Password=123"
                }
        'for SQL
        Dim sql As String = "select img from picture where id = " & id
        Dim command1 = New SqlCommand(sql, conn)
        conn.Open()
        Dim reader As SqlDataReader = command1.ExecuteReader
        reader.Read()
        Dim bitPic = CType(reader.GetValue(0), Byte())
        conn.Close()

        Dim mStream = New MemoryStream(bitPic)
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

    Public Function 患者总表_删除(pr1 As String, pr2 As String, pr3 As String) As Boolean
        Dim value = False
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

    Public Function Get_药品库存(remember As String) As DataSet
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
            Using sql As New SqlCommand("SELECT * FROM 挂号单详情 ORDER BY 序号 ASC")
                'sql.CommandTimeout = 300
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                Using dr As SqlDataReader = sql.ExecuteReader
                    dset.Load(dr, 3, "挂号单")
                End Using
            End Using
        End Using
        Return dset
    End Function

    Public Function Get_挂号单详情_男_女() As DataSet
        Dim dset As New DataSet("挂号单")
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("SELECT * FROM 挂号单详情_男_女")
                'sql.CommandTimeout = 300
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                Using dr As SqlDataReader = sql.ExecuteReader
                    If dr.HasRows Then
                        dset.Load(dr, 3, "男女")
                    End If
                End Using
            End Using
        End Using
        Return dset
    End Function

    Public Function 修改ID_患者总表() As Boolean
        Dim flag = False
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
                        Dim decod As String = UCase(Hex(value))

                        Using _
                            qt As New SqlCommand("update 患者总表 set 患者编号='" + decod + "' where 合作医疗号='" + value + "'", cn)
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

    Public Function Get门诊诊断模板_查询(诊断 As String) As DataSet
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

    Public Function Get门诊病历(患者编号 As String) As DataSet
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

    Public Function Add_挂号单(患者编号 As String, 结算方式 As String, 状态 As String) As Integer
        Dim val As Integer
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            '为了解决SQL引起的错误,引用了Try...
            'Try
            Using sql As New SqlCommand("dbo.DAL_挂号单_InsertCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@患者编号", 患者编号)
                sql.Parameters.AddWithValue("@结算方式", 结算方式)
                sql.Parameters.AddWithValue("@状态", 状态)
                val = sql.ExecuteNonQuery()
            End Using
            ' Catch ex As SqlException
            'MsgBox("出现错误:" + ex.Message, MsgBoxStyle.Information)
            '  Finally
            ' End Try
            'try 结束
        End Using
        Return val
    End Function

    Public Sub Add_门诊病历模板(诊断 As String, 主诉 As String, 医嘱建议 As String)
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

    Public Sub Set_入院单(患者编号 As String, 住院部 As String, 诊断 As String)
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

    Public Sub Del_住院单_待收费(患者编号 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("delete 住院单 where 患者编号='" & 患者编号 & "' and 状态='待收费'", cn)
                sql.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function Add_门诊处方(患者编号 As String, 药品名称 As String, 规格 As String, 数量 As Int16,
                             单位 As String, 剂量 As String, 单价 As Single, 金额 As Double, 用法 As String, 科室 As String,
                             医生 As String)
        Dim c As Integer
        Using cn As New SqlConnection(ConStr)
            cn.Open()

            Using sql As New SqlCommand("dbo.DAL_门诊处方_InsertCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@患者编号", 患者编号)
                sql.Parameters.AddWithValue("@药品名称", 药品名称)
                sql.Parameters.AddWithValue("@规格", 规格)
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

    Public Function Get_门诊处方(患者编号 As String) As DataSet
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

    Public Function Del_门诊处方(患者编号 As String, 药品名称 As String, 日期 As Date, 时间 As TimeSpan) As Integer
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

    Public Function Get_住院单(id As String) As DataSet
        Get_住院单 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("[dbo].[DAL_住院单_ID_SelectCommand]")
                sql.Connection = cn
                sql.CommandType = CommandType.StoredProcedure
                sql.Parameters.AddWithValue("@患者ID", id)

                Using da As New SqlDataAdapter
                    da.SelectCommand = sql
                    da.Fill(Get_住院单)
                End Using
            End Using
            cn.Close()
        End Using
        Return Get_住院单
    End Function

    Public Function Get_住院单_待就诊() As DataSet
        Get_住院单_待就诊 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("Select * from 住院单 where 状态='待就诊'")
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                Using da As New SqlDataAdapter
                    da.SelectCommand = sql
                    da.Fill(Get_住院单_待就诊)
                End Using
            End Using
        End Using
        Return Get_住院单_待就诊
    End Function

    Public Sub Del_住院单(id As Integer, 患者编号 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("DELETE 住院单 WHERE id=" & id & " and 患者编号='" & 患者编号 & "'")
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                sql.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function Get_检查科室() As List(Of String)
        Get_检查科室 = New List(Of String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select * from 检查科室") With {
                .Connection = cn,
                .CommandType = CommandType.Text
                }
                Using dr As SqlDataReader = sql.ExecuteReader
                    If dr.HasRows Then
                        Do While dr.Read
                            Get_检查科室.Add(dr.GetString(0))
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Function Get_检查项目名称(科室 As String) As List(Of String)
        Get_检查项目名称 = New List(Of String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select 项目名称 from 检查项目 where 所属科室='" & 科室 & "' and 是否可用=1 ORDER by ID") With {
                .Connection = cn,
                .CommandType = CommandType.Text
                }

                Using dr As SqlDataReader = sql.ExecuteReader
                    If dr.HasRows Then
                        Do While dr.Read
                            Get_检查项目名称.Add(dr.GetString(0))
                        Loop
                    End If
                End Using
            End Using
            cn.Close()
        End Using
    End Function

    Public Function Get_检查项(科室 As String, 子项 As String) As DataSet
        Get_检查项 = New DataSet("检查项")
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using _
                sql As _
                    New SqlCommand(
                        "select 项目名称,单位,价格 from 检查项目 where 所属科室='" & 科室 & "' and 项目名称='" & 子项 &
                        "' and 是否可用=1 ORDER by ID") With {
                            .Connection = cn,
                            .CommandType = CommandType.Text
                            }
                Using dr As SqlDataReader = sql.ExecuteReader
                    Get_检查项.Load(dr, 1, "检查项")
                End Using
            End Using
            cn.Close()
        End Using
    End Function

    Public Function Get_检查单(患者编号 As String) As DataSet
        Get_检查单 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("dbo.DAL_检查单_SelectCommand") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cn
                }
                sql.Parameters.AddWithValue("@患者编号", 患者编号)

                '*******两种填充方式********
                '***********第一种,数据适配器*************
                'sql.ExecuteNonQuery()
                'Using dr As New SqlDataAdapter
                '  dr.SelectCommand = sql
                '  dr.Fill(Get_检查单)
                '****注:不能于with通用,先执行后填充
                '****数据适配器主动
                '*********第二种,数据阅载器************
                Using dr As SqlDataReader = sql.ExecuteReader
                    Get_检查单.Load(dr, LoadOption.OverwriteChanges, "检查单")
                    '*******使用简单,反向操作,数据装载方式**********
                    '*****数据集主动
                End Using
            End Using
        End Using
    End Function

    Public Sub Add_检查单(患者编号 As String, 检查科室 As String, 检查项目 As String, 单位 As String, 价格 As Single, 申请科室 As String,
                       申请医师 As String, 状态 As String)
        Dim var_检查科室 = New SqlParameter
        Dim var_患者编号 = New SqlParameter

        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("dbo.DAL_检查单_InsertCommand") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cn
                }
                '避免外键连接出错。
                sql.Parameters.Add("@患者编号", SqlDbType.NVarChar, 10).Value = 患者编号
                sql.Parameters.Add("@检查科室", SqlDbType.NVarChar, 50).Value = 检查科室
                '  sql.Parameters.AddWithValue("@检查科室", 检查科室)
                sql.Parameters.AddWithValue("@检查项目", 检查项目)
                sql.Parameters.AddWithValue("@单位", 单位)
                sql.Parameters.AddWithValue("@价格", 价格)
                sql.Parameters.AddWithValue("@申请科室", 申请科室)
                sql.Parameters.AddWithValue("@申请医师", 申请医师)
                sql.Parameters.AddWithValue("@状态", 状态)
                sql.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Get_病区分类() As DataSet
        Get_病区分类 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select 病区名 from 病区分类") With {
                .CommandType = CommandType.Text,
                .Connection = cn
                }
                sql.ExecuteNonQuery()
                Using dr As New SqlDataAdapter
                    dr.SelectCommand = sql
                    dr.Fill(Get_病区分类)
                End Using
            End Using
        End Using
    End Function

    Public Function Get_客户端连接数() As Int32

        Dim count As Int32
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("SELECT COUNT(dbid) FROM sys.sysprocesses;")
                sql.CommandType = CommandType.Text
                sql.Connection = cn
                Using dr As SqlDataReader = sql.ExecuteReader()
                    dr.Read()
                    '必须进行读取操作
                    count = Convert.ToInt32(dr.GetValue(0))
                    dr.Close()
                End Using
                sql.Dispose()
            End Using
            cn.Close()
        End Using
        Return count
    End Function

    Public Function Get_挂号单详情_结算方式() As DataSet
        Get_挂号单详情_结算方式 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select * from 挂号单详情_结算方式")
                sql.CommandType = CommandType.Text
                sql.Connection = cn
                Using dr As SqlDataReader = sql.ExecuteReader()
                    If dr.HasRows Then
                        Get_挂号单详情_结算方式.Load(dr, 3, "今日挂号单_结算方式_DataSet")
                    End If
                End Using
            End Using
        End Using
        Return Get_挂号单详情_结算方式
    End Function

    Public Function Get_门诊病历模板() As DataSet
        Get_门诊病历模板 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select * from 门诊病历模板 order by ID ASC")
                sql.Connection = cn
                sql.CommandType = CommandType.Text
                sql.CommandTimeout = 200 '2second
                Using dr As SqlDataReader = sql.ExecuteReader()
                    If dr.HasRows Then
                        Get_门诊病历模板.Load(dr, 3, "诊断参考")
                    End If
                End Using
            End Using
        End Using
        Return Get_门诊病历模板
    End Function

    Public Sub Update_门诊病历模板(ByVal id As Int32, ByVal 诊断 As String, ByVal 主诉 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("update 门诊病历模板 set 诊断='" & 诊断 & "' , 主诉='" & 主诉 & "' where id=" & id)
                sql.CommandType = CommandType.Text
                sql.Connection = cn
                sql.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub Delete_门诊病历模板(ByVal ID As Int32)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand With {
                .CommandText = "delete FROM 门诊病历模板 WHERE ID=" & ID,
                .CommandType = CommandType.Text,
                .Connection = cn,
                .CommandTimeout = 200
                }
                sql.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function Get_药库资料() As DataSet
        Get_药库资料 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select * from 库房资料 order by 编号", cn)
                sql.CommandType = CommandType.Text
                sql.CommandTimeout = 200
                Using dr As SqlDataReader = sql.ExecuteReader()
                    If dr.HasRows Then
                        Get_药库资料.Load(dr, 3, "药库资料")
                    End If
                End Using
            End Using
        End Using
        Return Get_药库资料
    End Function
    Public Sub Add_药库资料(名称 As String, 位置 As String, 备注 As String)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand
                sql.CommandText = "insert into 库房资料(名称,位置,备注) values(@par1,@par2,@par3)"
                sql.CommandTimeout = 200
                sql.Parameters.AddWithValue("@par1", 名称)
                sql.Parameters.AddWithValue("@par2", 位置)
                sql.Parameters.AddWithValue("@par2", 备注)
                sql.Connection = cn
                sql.ExecuteNonQuery()

            End Using
        End Using
    End Sub
    Public Sub Del_药库资料(编号 As Integer)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("delete from 药库资料 where 编号=" + 编号, cn)
                sql.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Get_药典() As SqlDataAdapter
        Dim 药典 = New DataSet
        Dim dadapter As SqlDataAdapter
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select * from 药典 order by ID", cn)
                Using dr As SqlDataReader = sql.ExecuteReader
                    药典.Load(dr, 3, "药典")
                    dadapter = New SqlDataAdapter
                    dadapter.SelectCommand = sql
                    dadapter.Fill(药典)
                End Using
            End Using
        End Using
        Return dadapter
    End Function
    Public Sub Del_药典(ID As Integer)
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("delete fom 药典 where id='" + ID + "'")
                sql.Connection = cn
                sql.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub Add_药典(流水号 As Integer, 通用名 As String, 药品类型 As String, 速记码 As String, 生产企业_总代理商 As String, 药库规格 As String, 剂型 As String, 采购价 As Single)
        Dim result As Integer
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("dbo.DAL_药典_InsertCommand")
                sql.CommandType = CommandType.StoredProcedure
                sql.Connection = cn
                sql.Parameters.AddWithValue("@流水号", 流水号)
                sql.Parameters.AddWithValue("@通用名", 通用名)
                sql.Parameters.AddWithValue("@药品类型", 药品类型)
                sql.Parameters.AddWithValue("@速记码", 速记码)
                sql.Parameters.AddWithValue("@生产企业_总代理商", 生产企业_总代理商)
                sql.Parameters.AddWithValue("@药库规格", 药库规格)
                sql.Parameters.AddWithValue("@剂型", 剂型)
                sql.Parameters.AddWithValue("@采购价", 采购价)
                result = sql.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Get_住院单() As DataSet
        Get_住院单 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select * from 住院单", cn)
                Dim dreader As SqlDataReader = sql.ExecuteReader()
                Get_住院单.Load(dreader, 3, "住院单")
            End Using
        End Using
        Return Get_住院单
    End Function

    Public Function Get_收费记录(患者编号 As String) As DataSet
        Get_收费记录 = New DataSet
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select 流水号,收费日期,收费时间,收费原因,收费金额,收费人 from 收费记录 where 患者编号='" & 患者编号 & "'", cn)
                Dim dr As SqlDataReader = sql.ExecuteReader()
                Get_收费记录.Load(dr, 3, "收费记录")
            End Using
        End Using
        Return Get_收费记录
    End Function
    Public Function 检验用户(id As String, pwd As String) As String()
        Dim result(3) As String
        Using cn As New SqlConnection(ConStr)
            cn.Open()
            Using sql As New SqlCommand("select 用户名,科室,职位 from 用户表 where id=" + id + " and 密码='" + pwd + "'", cn)
                Dim dr As SqlDataReader = sql.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read
                        result(0) = dr.GetString(0) '用户名
                        result(1) = dr.GetString(1) '科室
                        result(2) = dr.GetString(2) '职位
                    End While
                Else
                    Console.WriteLine("没有数集")
                End If
            End Using
        End Using
        Return result
    End Function
    Public Function 密码验证(id As String, pwd As String) As Boolean
        Dim result As Boolean = False
        Using cn As New SqlConnection(ConStr)
            Using sql As New SqlCommand("select * from 用户表 where id='" + id + "'" + " and 密码='" + "'", cn)
                cn.Open()
                Dim dr As SqlDataReader = sql.ExecuteReader
                If dr.HasRows Then
                    result = True
                End If
            End Using
        End Using
        Return result
    End Function
    Public Function Get_已执行医嘱() As DataSet
        Get_已执行医嘱 = New DataSet
        Using cn As New SqlConnection(ConStr)
            Using sql As New SqlCommand("SELECT * FROM 已执行医嘱 ORDER BY 床号,日期, 时间 ASC")
                cn.Open()
                sql.Connection = cn
                sql.CommandTimeout = 200
                Dim dr As SqlDataReader = sql.ExecuteReader
                Get_已执行医嘱.Load(dr, LoadOption.PreserveChanges, "已执行医嘱")
            End Using
        End Using
    End Function
    Public Sub Update_密码(ID As String, pwd As String)
        Using cn As New SqlConnection(ConStr)
            Using sql As New SqlCommand("update 用户表 set 密码='" + "' where id='" + ID + "'")
                sql.Connection = cn
                cn.Open()
                sql.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function Get_住院病历(患者编号 As String) As DataSet
        Get_住院病历 = New DataSet
        Using cn As New SqlConnection(ConStr)
            Using sql As New SqlCommand("SELECT * FROM 住院病历 where 患者编号='" + 患者编号 + "' ORDER BY 就诊日期")
                cn.Open()
                sql.Connection = cn
                sql.CommandTimeout = 200
                Dim dr As SqlDataReader = sql.ExecuteReader
                Get_住院病历.Load(dr, LoadOption.PreserveChanges, "住院病历")
            End Using
        End Using
        Return Get_住院病历
    End Function
    Public Function Get_患者信息(患者编号 As String) As String()
        Dim result(3) As String
        Using cn As New SqlConnection(ConStr)
            Using sql As New SqlCommand("select 患者姓名,性别, 年龄 from 患者总表 where 患者编号='" + 患者编号 + "'")
                sql.Connection = cn
                cn.Open()
                Dim dr As SqlDataReader = sql.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read
                        result(0) = dr.GetString(0)
                        result(1) = dr.GetString(1)
                        result(2) = dr.GetByte(2)
                    End While
                End If
            End Using
        End Using
        Return result
    End Function
End Module