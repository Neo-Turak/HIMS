Module 汉字处理
    Function get_拼音(ByVal str As String) As String

        Dim strasc

        strasc = Asc(str)

        Select Case strasc

            Case -20319 To -20318 : get_拼音 = "a "

            Case -20317 To -20305 : get_拼音 = "ai "

            Case -20304 To -20296 : get_拼音 = "an "

            Case -20295 To -20293 : get_拼音 = "ang "

            Case -20292 To -20284 : get_拼音 = "ao "

            Case -20283 To -20266 : get_拼音 = "ba "

            Case -20265 To -20258 : get_拼音 = "bai "

            Case -20257 To -20243 : get_拼音 = "ban "

            Case -20242 To -20231 : get_拼音 = "bang "

            Case -20230 To -20052 : get_拼音 = "bao "

            Case -20051 To -20037 : get_拼音 = "bei "

            Case -20036 To -20033 : get_拼音 = "ben "

            Case -20032 To -20027 : get_拼音 = "beng "

            Case -20026 To -20003 : get_拼音 = "bi "

            Case -20002 To -19991 : get_拼音 = "bian "

            Case -19990 To -19987 : get_拼音 = "biao "

            Case -19986 To -19983 : get_拼音 = "bie "

            Case -19982 To -19977 : get_拼音 = "bin "

            Case -19976 To -19806 : get_拼音 = "bing "

            Case -19805 To -19785 : get_拼音 = "bo "

            Case -19784 To -19776 : get_拼音 = "bu "

            Case -19775 To -19775 : get_拼音 = "ca "

            Case -19774 To -19764 : get_拼音 = "cai "

            Case -19763 To -19757 : get_拼音 = "can "

            Case -19756 To -19752 : get_拼音 = "cang "

            Case -19751 To -19747 : get_拼音 = "cao "

            Case -19746 To -19742 : get_拼音 = "ce "

            Case -19741 To -19740 : get_拼音 = "ceng "

            Case -19739 To -19729 : get_拼音 = "cha "

            Case -19728 To -19726 : get_拼音 = "chai "

            Case -19725 To -19716 : get_拼音 = "chan "

            Case -19715 To -19541 : get_拼音 = "chang "

            Case -19540 To -19532 : get_拼音 = "chao "

            Case -19531 To -19526 : get_拼音 = "che "

            Case -19525 To -19516 : get_拼音 = "chen "

            Case -19515 To -19501 : get_拼音 = "cheng "

            Case -19500 To -19485 : get_拼音 = "chi "

            Case -19484 To -19480 : get_拼音 = "chong "

            Case -19479 To -19468 : get_拼音 = "chou "

            Case -19467 To -19290 : get_拼音 = "chu "

            Case -19289 To -19289 : get_拼音 = "chuai "

            Case -19288 To -19282 : get_拼音 = "chuan "

            Case -19281 To -19276 : get_拼音 = "chuang "

            Case -19275 To -19271 : get_拼音 = "chui "

            Case -19270 To -19264 : get_拼音 = "chun "

            Case -19263 To -19262 : get_拼音 = "chuo "

            Case -19261 To -19250 : get_拼音 = "ci "

            Case -19249 To -19244 : get_拼音 = "cong "

            Case -19243 To -19243 : get_拼音 = "cou "

            Case -19242 To -19239 : get_拼音 = "cu "

            Case -19238 To -19236 : get_拼音 = "cuan "

            Case -19235 To -19228 : get_拼音 = "cui "

            Case -19227 To -19225 : get_拼音 = "cun "

            Case -19224 To -19219 : get_拼音 = "cuo "

            Case -19218 To -19213 : get_拼音 = "da "

            Case -19212 To -19039 : get_拼音 = "dai "

            Case -19038 To -19024 : get_拼音 = "dan "

            Case -19023 To -19019 : get_拼音 = "dang "

            Case -19018 To -19007 : get_拼音 = "dao "

            Case -19006 To -19004 : get_拼音 = "de "

            Case -19003 To -18997 : get_拼音 = "deng "

            Case -18996 To -18978 : get_拼音 = "di "

            Case -18977 To -18962 : get_拼音 = "dian "

            Case -18961 To -18953 : get_拼音 = "diao "

            Case -18952 To -18784 : get_拼音 = "die "

            Case -18783 To -18775 : get_拼音 = "ding "

            Case -18774 To -18774 : get_拼音 = "diu "

            Case -18773 To -18527 : get_拼音 = "dong "

            Case -10068 To -10068 : get_拼音 = "e "

            Case -18526 To -18519 : get_拼音 = "fa "

            Case -18518 To -18502 : get_拼音 = "fan "

            Case -18501 To -18491 : get_拼音 = "fang "

            Case -18490 To -18479 : get_拼音 = "fei "

            Case -18478 To -18464 : get_拼音 = "fen "

            Case -18463 To -18449 : get_拼音 = "feng "

            Case -18448 To -18448 : get_拼音 = "fo "

            Case -18447 To -18447 : get_拼音 = "fou "

            Case -18446 To -18240 : get_拼音 = "fu "

            Case -18239 To -18238 : get_拼音 = "ga "

            Case -18237 To -18232 : get_拼音 = "gai "

            Case -18231 To -18221 : get_拼音 = "gan "

            Case -18220 To -18212 : get_拼音 = "gang "

            Case -18211 To -18202 : get_拼音 = "gao "

            Case -18201 To -18185 : get_拼音 = "ge "

            Case -18184 To -18184 : get_拼音 = "gei "

            Case -18183 To -18182 : get_拼音 = "gen "

            Case -18181 To -18013 : get_拼音 = "geng "

            Case -18012 To -17998 : get_拼音 = "gong "

            Case -17997 To -17989 : get_拼音 = "gou "

            Case -17988 To -17971 : get_拼音 = "gu "

            Case -17970 To -17965 : get_拼音 = "gua "

            Case -17964 To -17962 : get_拼音 = "guai "

            Case -17961 To -17951 : get_拼音 = "guan "

            Case -17950 To -17948 : get_拼音 = "guang "

            Case -17947 To -17932 : get_拼音 = "gui "

            Case -17931 To -17929 : get_拼音 = "gun "

            Case -17928 To -17923 : get_拼音 = "guo "

            Case -17922 To -17760 : get_拼音 = "ha "

            Case -17759 To -17753 : get_拼音 = "hai "

            Case -17752 To -17734 : get_拼音 = "han "

            Case -17733 To -17731 : get_拼音 = "hang "

            Case -17730 To -17722 : get_拼音 = "hao "

            Case -17721 To -17704 : get_拼音 = "he "

            Case -17703 To -17702 : get_拼音 = "hei "

            Case -17701 To -17698 : get_拼音 = "hen "

            Case -17697 To -17693 : get_拼音 = "heng "

            Case -17692 To -17684 : get_拼音 = "hong "

            Case -17683 To -17677 : get_拼音 = "hou "

            Case -17676 To -17497 : get_拼音 = "hu "

            Case -17496 To -17488 : get_拼音 = "hua "

            Case -17487 To -17483 : get_拼音 = "huai "

            Case -17482 To -17469 : get_拼音 = "huan "

            Case -17468 To -17455 : get_拼音 = "huang "

            Case -17454 To -17434 : get_拼音 = "hui "

            Case -17433 To -17428 : get_拼音 = "hun "

            Case -17427 To -17418 : get_拼音 = "huo "

            Case -17417 To -17203 : get_拼音 = "ji "

            Case -17202 To -17186 : get_拼音 = "jia "

            Case -17185 To -16984 : get_拼音 = "jian "

            Case -16983 To -16971 : get_拼音 = "jiang "

            Case -16970 To -16943 : get_拼音 = "jiao "

            Case -16942 To -16916 : get_拼音 = "jie "

            Case -16915 To -16734 : get_拼音 = "jin "

            Case -16733 To -16709 : get_拼音 = "jing "

            Case -16708 To -16707 : get_拼音 = "jiong "

            Case -16706 To -16690 : get_拼音 = "jiu "

            Case -16689 To -16665 : get_拼音 = "ju "

            Case -16664 To -16658 : get_拼音 = "juan "

            Case -16657 To -16648 : get_拼音 = "jue "

            Case -16647 To -16475 : get_拼音 = "jun "

            Case -16474 To -16471 : get_拼音 = "ka "

            Case -16470 To -16466 : get_拼音 = "kai "

            Case -16465 To -16460 : get_拼音 = "kan "

            Case -16459 To -16453 : get_拼音 = "kang "

            Case -16452 To -16449 : get_拼音 = "kao "

            Case -16448 To -16434 : get_拼音 = "ke "

            Case -16433 To -16430 : get_拼音 = "ken "

            Case -16429 To -16428 : get_拼音 = "keng "

            Case -4180 To -4180 : get_拼音 = "keng "

            Case -16427 To -16424 : get_拼音 = "kong "

            Case -16423 To -16420 : get_拼音 = "kou "

            Case -16419 To -16413 : get_拼音 = "ku "

            Case -16412 To -16408 : get_拼音 = "kua "

            Case -16407 To -16404 : get_拼音 = "kuai "

            Case -16403 To -16402 : get_拼音 = "kuan "

            Case -16401 To -16394 : get_拼音 = "kuang "

            Case -16393 To -16221 : get_拼音 = "kui "

            Case -16220 To -16217 : get_拼音 = "kun "

            Case -16216 To -16213 : get_拼音 = "kuo "

            Case -16212 To -16206 : get_拼音 = "la "

            Case -16205 To -16203 : get_拼音 = "lai "

            Case -16202 To -16188 : get_拼音 = "lan "

            Case -16187 To -16181 : get_拼音 = "lang "

            Case -16180 To -16172 : get_拼音 = "lao "

            Case -16171 To -16170 : get_拼音 = "le "

            Case -16169 To -16159 : get_拼音 = "lei "

            Case -16158 To -16156 : get_拼音 = "leng "

            Case -16155 To -15960 : get_拼音 = "li "

            Case -15959 To -15959 : get_拼音 = "lia "

            Case -15958 To -15945 : get_拼音 = "lian "

            Case -15944 To -15934 : get_拼音 = "liang "

            Case -15933 To -15921 : get_拼音 = "liao "

            Case -15920 To -15916 : get_拼音 = "lie "

            Case -15915 To -15904 : get_拼音 = "lin "

            Case -15903 To -15890 : get_拼音 = "ling "

            Case -15889 To -15879 : get_拼音 = "liu "

            Case -15878 To -15708 : get_拼音 = "long "

            Case -15707 To -15702 : get_拼音 = "lou "

            Case -15701 To -15682 : get_拼音 = "lu "

            Case -15681 To -15668 : get_拼音 = "lv "

            Case -15667 To -15662 : get_拼音 = "luan "

            Case -15661 To -15660 : get_拼音 = "lue "

            Case -15659 To -15653 : get_拼音 = "lun "

            Case -15652 To -15641 : get_拼音 = "luo "

            Case -15640 To -15632 : get_拼音 = "ma "

            Case -15631 To -15626 : get_拼音 = "mai "

            Case -15625 To -15455 : get_拼音 = "man "

            Case -15454 To -15449 : get_拼音 = "mang "

            Case -15448 To -15437 : get_拼音 = "mao "

            Case -15436 To -15436 : get_拼音 = "me "

            Case -15435 To -15420 : get_拼音 = "mei "

            Case -15419 To -15417 : get_拼音 = "men "

            Case -15416 To -15409 : get_拼音 = "meng "

            Case -15408 To -15395 : get_拼音 = "mi "

            Case -15394 To -15386 : get_拼音 = "mian "

            Case -15385 To -15378 : get_拼音 = "miao "

            Case -15377 To -15376 : get_拼音 = "mie "

            Case -15375 To -15370 : get_拼音 = "min "

            Case -15369 To -15364 : get_拼音 = "ming "

            Case -15363 To -15363 : get_拼音 = "miu "

            Case -15362 To -15184 : get_拼音 = "mo "

            Case -15183 To -15181 : get_拼音 = "mou "

            Case -15180 To -15166 : get_拼音 = "mu "

            Case -15165 To -15159 : get_拼音 = "na "

            Case -15158 To -15154 : get_拼音 = "nai "

            Case -15153 To -15151 : get_拼音 = "nan "

            Case -15150 To -15150 : get_拼音 = "nang "

            Case -15149 To -15145 : get_拼音 = "nao "

            Case -15144 To -15144 : get_拼音 = "ne "

            Case -15143 To -15142 : get_拼音 = "nei "

            Case -15141 To -15141 : get_拼音 = "nen "

            Case -15140 To -15140 : get_拼音 = "neng "

            Case -15139 To -15129 : get_拼音 = "ni "

            Case -15128 To -15122 : get_拼音 = "nian "

            Case -15121 To -15120 : get_拼音 = "niang "

            Case -15119 To -15118 : get_拼音 = "niao "

            Case -15117 To -15111 : get_拼音 = "nie "

            Case -15110 To -15110 : get_拼音 = "nin "

            Case -15109 To -14942 : get_拼音 = "ning "

            Case -14941 To -14938 : get_拼音 = "niu "

            Case -14937 To -14934 : get_拼音 = "nong "

            Case -14933 To -14931 : get_拼音 = "nu "

            Case -14930 To -14930 : get_拼音 = "nv "

            Case -14929 To -14929 : get_拼音 = "nuan "

            Case -14928 To -14927 : get_拼音 = "nue "

            Case -14926 To -14923 : get_拼音 = "nuo "

            Case -14922 To -14922 : get_拼音 = "o "

            Case -14921 To -14915 : get_拼音 = "ou "

            Case -14914 To -14909 : get_拼音 = "pa "

            Case -14908 To -14903 : get_拼音 = "pai "

            Case -14902 To -14895 : get_拼音 = "pan "

            Case -14894 To -14890 : get_拼音 = "pang "

            Case -14889 To -14883 : get_拼音 = "pao "

            Case -14882 To -14874 : get_拼音 = "pei "

            Case -14873 To -14872 : get_拼音 = "pen "

            Case -14871 To -14858 : get_拼音 = "peng "

            Case -14857 To -14679 : get_拼音 = "pi "

            Case -14678 To -14675 : get_拼音 = "pian "

            Case -14674 To -14671 : get_拼音 = "piao "

            Case -14670 To -14669 : get_拼音 = "pie "

            Case -14668 To -14664 : get_拼音 = "pin "

            Case -14663 To -14655 : get_拼音 = "ping "

            Case -14654 To -14646 : get_拼音 = "po "

            Case -14645 To -14631 : get_拼音 = "pu "

            Case -14630 To -14595 : get_拼音 = "qi "

            Case -14594 To -14430 : get_拼音 = "qia "

            Case -14429 To -14408 : get_拼音 = "qian "

            Case -14407 To -14400 : get_拼音 = "qiang "

            Case -4145 To -4145 : get_拼音 = "qiang "

            Case -14399 To -14385 : get_拼音 = "qiao "

            Case -14384 To -14380 : get_拼音 = "qie "

            Case -14379 To -14369 : get_拼音 = "qin "

            Case -14368 To -14356 : get_拼音 = "qing "

            Case -14355 To -14354 : get_拼音 = "qiong "

            Case -14353 To -14346 : get_拼音 = "qiu "

            Case -14345 To -14171 : get_拼音 = "qu "

            Case -14170 To -14160 : get_拼音 = "quan "

            Case -14159 To -14152 : get_拼音 = "que "

            Case -14151 To -14150 : get_拼音 = "qun "

            Case -14149 To -14146 : get_拼音 = "ran "

            Case -14145 To -14141 : get_拼音 = "rang "

            Case -14140 To -14138 : get_拼音 = "rao "

            Case -14137 To -14136 : get_拼音 = "re "

            Case -14135 To -14126 : get_拼音 = "ren "

            Case -14125 To -14124 : get_拼音 = "reng "

            Case -14123 To -14123 : get_拼音 = "ri "

            Case -14122 To -14113 : get_拼音 = "rong "

            Case -14112 To -14110 : get_拼音 = "rou "

            Case -14109 To -14100 : get_拼音 = "ru "

            Case -14099 To -14098 : get_拼音 = "ruan "

            Case -14097 To -14095 : get_拼音 = "rui "

            Case -14094 To -14093 : get_拼音 = "run "

            Case -14092 To -14091 : get_拼音 = "ruo "

            Case -14090 To -14088 : get_拼音 = "sa "

            Case -14087 To -14084 : get_拼音 = "sai "

            Case -14083 To -13918 : get_拼音 = "san "

            Case -13917 To -13915 : get_拼音 = "sang "

            Case -13914 To -13911 : get_拼音 = "sao "

            Case -13910 To -13908 : get_拼音 = "se "

            Case -13907 To -13907 : get_拼音 = "sen "

            Case -13906 To -13906 : get_拼音 = "seng "

            Case -3121 To -3121 : get_拼音 = "sheng "

            Case -13905 To -13897 : get_拼音 = "sha "

            Case -13896 To -13895 : get_拼音 = "shai "

            Case -13894 To -13879 : get_拼音 = "shan "

            Case -13878 To -13871 : get_拼音 = "shang "

            Case -13870 To -13860 : get_拼音 = "shao "

            Case -13859 To -13848 : get_拼音 = "she "

            Case -13847 To -13832 : get_拼音 = "shen "

            Case -13831 To -13659 : get_拼音 = "sheng "

            Case -13658 To -13612 : get_拼音 = "shi "

            Case -13611 To -13602 : get_拼音 = "shou "

            Case -13601 To -13407 : get_拼音 = "shu "

            Case -13406 To -13405 : get_拼音 = "shua "

            Case -13404 To -13401 : get_拼音 = "shuai "

            Case -13400 To -13399 : get_拼音 = "shuan "

            Case -13398 To -13396 : get_拼音 = "shuang "

            Case -13395 To -13392 : get_拼音 = "shui "

            Case -13391 To -13388 : get_拼音 = "shun "

            Case -13387 To -13384 : get_拼音 = "shuo "

            Case -13383 To -13368 : get_拼音 = "si "

            Case -13367 To -13360 : get_拼音 = "song "

            Case -13359 To -13357 : get_拼音 = "sou "

            Case -13356 To -13344 : get_拼音 = "su "

            Case -13343 To -13341 : get_拼音 = "suan "

            Case -13340 To -13330 : get_拼音 = "sui "

            Case -13329 To -13327 : get_拼音 = "sun "

            Case -13326 To -13319 : get_拼音 = "suo "

            Case -13318 To -13148 : get_拼音 = "ta "

            Case -13147 To -13139 : get_拼音 = "tai "

            Case -13138 To -13121 : get_拼音 = "tan "

            Case -13120 To -13108 : get_拼音 = "tang "

            Case -13107 To -13097 : get_拼音 = "tao "

            Case -13096 To -13096 : get_拼音 = "te "

            Case -13095 To -13092 : get_拼音 = "teng "

            Case -13091 To -13077 : get_拼音 = "ti "

            Case -13076 To -13069 : get_拼音 = "tian "

            Case -13068 To -13064 : get_拼音 = "tiao "

            Case -13063 To -13061 : get_拼音 = "tie "

            Case -13060 To -12889 : get_拼音 = "ting "

            Case -12888 To -12876 : get_拼音 = "tong "

            Case -12875 To -12872 : get_拼音 = "tou "

            Case -12871 To -12861 : get_拼音 = "tu "

            Case -12860 To -12859 : get_拼音 = "tuan "

            Case -12858 To -12853 : get_拼音 = "tui "

            Case -12852 To -12850 : get_拼音 = "tun "

            Case -12849 To -12839 : get_拼音 = "tuo "

            Case -12838 To -12832 : get_拼音 = "wa "

            Case -12831 To -12830 : get_拼音 = "wai "

            Case -12829 To -12813 : get_拼音 = "wan "

            Case -12812 To -12803 : get_拼音 = "wang "

            Case -12802 To -12608 : get_拼音 = "wei "

            Case -12607 To -12598 : get_拼音 = "wen "

            Case -12597 To -12595 : get_拼音 = "weng "

            Case -12594 To -12586 : get_拼音 = "wo "

            Case -12585 To -12557 : get_拼音 = "wu "

            Case -12556 To -12360 : get_拼音 = "xi "

            Case -12359 To -12347 : get_拼音 = "xia "

            Case -12346 To -12321 : get_拼音 = "xian "

            Case -12320 To -12301 : get_拼音 = "xiang "

            Case -12300 To -12121 : get_拼音 = "xiao "

            Case -12120 To -12100 : get_拼音 = "xie "

            Case -12099 To -12090 : get_拼音 = "xin "

            Case -12089 To -12075 : get_拼音 = "xing "

            Case -12074 To -12068 : get_拼音 = "xiong "

            Case -12067 To -12059 : get_拼音 = "xiu "

            Case -12058 To -12040 : get_拼音 = "xu "

            Case -12039 To -11868 : get_拼音 = "xuan "

            Case -11867 To -11862 : get_拼音 = "xue "

            Case -11861 To -11848 : get_拼音 = "xun "

            Case -11847 To -11832 : get_拼音 = "ya "

            Case -11831 To -11799 : get_拼音 = "yan "

            Case -11798 To -11782 : get_拼音 = "yang "

            Case -11781 To -11605 : get_拼音 = "yao "

            Case -11604 To -11590 : get_拼音 = "ye "

            Case -11589 To -11537 : get_拼音 = "yi "

            Case -11536 To -11359 : get_拼音 = "yin "

            Case -11358 To -11341 : get_拼音 = "ying "

            Case -11340 To -11340 : get_拼音 = "yo "

            Case -11339 To -11325 : get_拼音 = "yong "

            Case -11324 To -11304 : get_拼音 = "you "

            Case -11303 To -11098 : get_拼音 = "yu "

            Case -11097 To -11078 : get_拼音 = "yuan "

            Case -11077 To -11068 : get_拼音 = "yue "

            Case -11067 To -11056 : get_拼音 = "yun "

            Case -11055 To -11053 : get_拼音 = "za "

            Case -11052 To -11046 : get_拼音 = "zai "

            Case -11045 To -11042 : get_拼音 = "zan "

            Case -11041 To -11039 : get_拼音 = "zang "

            Case -11038 To -11025 : get_拼音 = "zao "

            Case -11024 To -11021 : get_拼音 = "ze "

            Case -11020 To -11020 : get_拼音 = "zei "

            Case -11019 To -11019 : get_拼音 = "zen "

            Case -11018 To -11015 : get_拼音 = "zeng "

            Case -11014 To -10839 : get_拼音 = "zha "

            Case -10838 To -10833 : get_拼音 = "zhai "

            Case -10832 To -10816 : get_拼音 = "zhan "

            Case -10815 To -10801 : get_拼音 = "zhang "

            Case -10800 To -10791 : get_拼音 = "zhao "

            Case -10790 To -10781 : get_拼音 = "zhe "

            Case -10780 To -10765 : get_拼音 = "zhen "

            Case -10764 To -10588 : get_拼音 = "zheng "

            Case -10587 To -10545 : get_拼音 = "zhi "

            Case -10544 To -10534 : get_拼音 = "zhong "

            Case -10533 To -10520 : get_拼音 = "zhou "

            Case -10519 To -10332 : get_拼音 = "zhu "

            Case -10331 To -10330 : get_拼音 = "zhua "

            Case -10329 To -10329 : get_拼音 = "zhuai "

            Case -10328 To -10323 : get_拼音 = "zhuan "

            Case -10322 To -10316 : get_拼音 = "zhuang "

            Case -10315 To -10310 : get_拼音 = "zhui "

            Case -10309 To -10308 : get_拼音 = "zhun "

            Case -10307 To -10297 : get_拼音 = "zhuo "

            Case -10296 To -10282 : get_拼音 = "zi "

            Case -10281 To -10275 : get_拼音 = "zong "

            Case -10274 To -10271 : get_拼音 = "zou "

            Case -10270 To -10263 : get_拼音 = "zu "

            Case -10262 To -10261 : get_拼音 = "zuan "

            Case -10260 To -10257 : get_拼音 = "zui "

            Case -10256 To -10255 : get_拼音 = "zun "

            Case -10250 To -10250 : get_拼音 = "zuo "

            Case -10254 To -10254 : get_拼音 = "zuo "

            Case -10247 To -10247 : get_拼音 = "zuo "

            Case -10248 To -10248 : get_拼音 = "zuo "

            Case Else : get_拼音 = str

        End Select

    End Function

    Function 汉字to拼音(ByVal str As String) As String

        汉字to拼音 = ""

        For i As Integer = 1 To Len(str) Step 1

            汉字to拼音 = 汉字to拼音 & get_拼音(Mid(str, i, 1))

        Next i

        Return 汉字to拼音

    End Function

    Function get_首字母(ByVal 汉字 As String) As String

        Dim strasc
        strasc = Asc(汉字)
        Select Case strasc

            Case -20319 To -20284 : get_首字母 = "A"

            Case -20283 To -19776 : get_首字母 = "B"

            Case -19775 To -19219 : get_首字母 = "C"

            Case -19218 To -18527 : get_首字母 = "D"

            Case -10068 To -10068 : get_首字母 = "E"

            Case -18526 To -18240 : get_首字母 = "F"

            Case -18239 To -17923 : get_首字母 = "G"

            Case -17922 To -17418 : get_首字母 = "H"

            Case -17417 To -16475 : get_首字母 = "J"

            Case -16474 To -16213 : get_首字母 = "K"

            Case -16212 To -15641 : get_首字母 = "L"

            Case -15640 To -15166 : get_首字母 = "M"

            Case -15165 To -14923 : get_首字母 = "N"

            Case -14922 To -14915 : get_首字母 = "O"

            Case -14914 To -14631 : get_首字母 = "P"

            Case -14630 To -14150 : get_首字母 = "Q"

            Case -14149 To -14091 : get_首字母 = "R"

            Case -14090 To -13319 : get_首字母 = "S"

            Case -13318 To -12839 : get_首字母 = "T"

            Case -12838 To -12557 : get_首字母 = "W"

            Case -12556 To -11848 : get_首字母 = "X"

            Case -11847 To -11056 : get_首字母 = "Y"

            Case -11055 To -10248 : get_首字母 = "Z"

            Case Else : get_首字母 = 汉字

        End Select
    End Function
End Module