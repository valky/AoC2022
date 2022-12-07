using D7.FileSystem;
using File = D7.FileSystem.File;
using Directory = D7.FileSystem.Directory;


string inputs = "$ cd /\r\n$ ls\r\ndir blrnnv\r\ndir ctfjwl\r\ndir dqf\r\n135993 dqqbcfr\r\ndir ftj\r\n125510 fzjdz\r\ndir jvtlfbzr\r\n31762 lsvw.lwr\r\ndir qfstpm\r\ndir sbprmc\r\ndir svbnljr\r\ndir tchbjclg\r\ndir wtm\r\ndir ztrz\r\n$ cd blrnnv\r\n$ ls\r\n169869 mjjj.wnq\r\n$ cd ..\r\n$ cd ctfjwl\r\n$ ls\r\n209537 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd dqf\r\n$ ls\r\n205200 hnbqlmmg\r\n80316 lmw.zmd\r\ndir mwj\r\n122312 tsrwvqbg.tzh\r\n$ cd mwj\r\n$ ls\r\n18195 bddslhrg.twf\r\n122813 qfccg.crl\r\n$ cd ..\r\n$ cd ..\r\n$ cd ftj\r\n$ ls\r\ndir clchr\r\ndir hmd\r\n40232 vtzlv\r\n$ cd clchr\r\n$ ls\r\ndir sbzf\r\n$ cd sbzf\r\n$ ls\r\n257770 thwhz.pgp\r\n$ cd ..\r\n$ cd ..\r\n$ cd hmd\r\n$ ls\r\n62643 bddslhrg.qzl\r\ndir lfpm\r\n277745 sgddpc\r\n117478 vjchlsrc.cmh\r\n7911 zzdpcnmt.qbf\r\n$ cd lfpm\r\n$ ls\r\n107158 bddslhrg\r\n253844 fzjdz.mlw\r\n217005 glzsnz.cvs\r\n71371 qfccg.crl\r\n193163 sdmmmds.nwt\r\ndir vlnbm\r\n$ cd vlnbm\r\n$ ls\r\n143113 lwhtsvg.bjm\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jvtlfbzr\r\n$ ls\r\ndir gwz\r\ndir hfftvmw\r\ndir jlftgw\r\ndir nnpvwtvt\r\n98713 wtbzpqvb\r\n$ cd gwz\r\n$ ls\r\n161853 blfnwqtm.vhw\r\n180524 fbqpql.bbw\r\ndir jvrdcf\r\ndir ldcmtwvt\r\ndir pjm\r\ndir qjj\r\n$ cd jvrdcf\r\n$ ls\r\n42681 bddslhrg\r\ndir cbcq\r\ndir fzjdz\r\ndir ghwnd\r\ndir gpbhtj\r\ndir hsmlb\r\ndir mjjj\r\n129934 sdmmmds.nwt\r\ndir wdvqhn\r\n196970 zzdpcnmt.qbf\r\n$ cd cbcq\r\n$ ls\r\ndir hsw\r\n262458 lbhzblh.zfn\r\ndir qbpvrr\r\n205708 sdmmmds.nwt\r\n263842 tqcgmwbj.bcn\r\n4847 vjchlsrc.cmh\r\n72550 wnmpdtrr.zrc\r\n$ cd hsw\r\n$ ls\r\ndir rdvfwbw\r\n$ cd rdvfwbw\r\n$ ls\r\ndir fthdrqnr\r\n$ cd fthdrqnr\r\n$ ls\r\n31974 htnpjdr.wsl\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qbpvrr\r\n$ ls\r\n198987 nnhpdvv.vvn\r\n$ cd ..\r\n$ cd ..\r\n$ cd fzjdz\r\n$ ls\r\n149832 ldb.qnt\r\n183866 nbnzfplj.lrs\r\n$ cd ..\r\n$ cd ghwnd\r\n$ ls\r\n177598 ggchv.tsv\r\n163367 mjjj\r\n13258 pdcf.flm\r\n$ cd ..\r\n$ cd gpbhtj\r\n$ ls\r\ndir cvm\r\n160598 fcng.sbf\r\n272547 ndnlzb\r\n285657 pvs.ldf\r\n166261 sdmmmds.nwt\r\n207433 zzdpcnmt.qbf\r\n$ cd cvm\r\n$ ls\r\n246462 fpwvfs.gpb\r\n133303 vjchlsrc.cmh\r\n$ cd ..\r\n$ cd ..\r\n$ cd hsmlb\r\n$ ls\r\n252425 tqcgmwbj.bcn\r\n$ cd ..\r\n$ cd mjjj\r\n$ ls\r\n96351 fvgj\r\n272667 qfccg.crl\r\n196309 ssv.ljs\r\n$ cd ..\r\n$ cd wdvqhn\r\n$ ls\r\n190200 sdmmmds.nwt\r\ndir tjgfcs\r\n214364 tqcgmwbj.bcn\r\n174218 wqpmmgtd\r\n$ cd tjgfcs\r\n$ ls\r\ndir gngb\r\n268455 hqctmf.cdg\r\n242060 prbwvv\r\n$ cd gngb\r\n$ ls\r\n102313 fhqgpb.cqc\r\n77189 mjjj.cdw\r\n163701 sdmmmds.nwt\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ldcmtwvt\r\n$ ls\r\ndir bqmbrr\r\ndir cfcfnspz\r\ndir fzjdz\r\ndir gvd\r\ndir mpqtgd\r\n9560 mqfdcz.wqt\r\n75810 shps\r\n249000 tqcgmwbj.bcn\r\n139099 zdv.zgz\r\ndir zpct\r\n$ cd bqmbrr\r\n$ ls\r\n175893 hwrdtwsv.brd\r\n$ cd ..\r\n$ cd cfcfnspz\r\n$ ls\r\ndir gmzsn\r\ndir gvrfbt\r\n105314 mjjj\r\n181873 vjchlsrc.cmh\r\n$ cd gmzsn\r\n$ ls\r\ndir bddslhrg\r\n$ cd bddslhrg\r\n$ ls\r\ndir cspptmpm\r\n258841 fzjdz.bfs\r\ndir npmh\r\n72584 qfccg.crl\r\n$ cd cspptmpm\r\n$ ls\r\n239223 fzjdz\r\n11003 sdmmmds.nwt\r\n73589 tqcgmwbj.bcn\r\n251204 vdz.jcd\r\n$ cd ..\r\n$ cd npmh\r\n$ ls\r\n186878 bddslhrg\r\n264830 bddslhrg.gdq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd gvrfbt\r\n$ ls\r\n200067 zcvjj\r\n$ cd ..\r\n$ cd ..\r\n$ cd fzjdz\r\n$ ls\r\ndir bddslhrg\r\ndir fvqszrj\r\ndir gqcdtjzj\r\ndir pcfr\r\n250120 pqqbpmr\r\ndir qbpvrr\r\n$ cd bddslhrg\r\n$ ls\r\n72852 sjn\r\n$ cd ..\r\n$ cd fvqszrj\r\n$ ls\r\ndir mmzcqr\r\n24439 tqcgmwbj.bcn\r\ndir vhpqjr\r\n$ cd mmzcqr\r\n$ ls\r\ndir gzfqggrr\r\n$ cd gzfqggrr\r\n$ ls\r\n162528 frdgcr.gnb\r\n$ cd ..\r\n$ cd ..\r\n$ cd vhpqjr\r\n$ ls\r\n194144 mjjj\r\n$ cd ..\r\n$ cd ..\r\n$ cd gqcdtjzj\r\n$ ls\r\n231917 pftb\r\n174091 vbzfgtwp\r\n$ cd ..\r\n$ cd pcfr\r\n$ ls\r\ndir dtbws\r\n76624 qfccg.crl\r\ndir qjqjd\r\ndir qjsldd\r\n$ cd dtbws\r\n$ ls\r\ndir vwjnsbjm\r\n$ cd vwjnsbjm\r\n$ ls\r\n56502 mjjj.jqj\r\n130426 qfglmz\r\n23199 vjchlsrc.cmh\r\n$ cd ..\r\n$ cd ..\r\n$ cd qjqjd\r\n$ ls\r\n71015 qfccg.crl\r\n40443 vjchlsrc.cmh\r\n$ cd ..\r\n$ cd qjsldd\r\n$ ls\r\n261945 fzjdz.vcw\r\n$ cd ..\r\n$ cd ..\r\n$ cd qbpvrr\r\n$ ls\r\n138915 fvh.sdp\r\ndir mdvqv\r\n168843 qbpvrr\r\n90599 tchbjclg\r\n226671 vjchlsrc.cmh\r\n$ cd mdvqv\r\n$ ls\r\n159050 bddslhrg\r\n2691 fzjdz\r\n245322 psr\r\n7732 zhnbgcc.lsc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd gvd\r\n$ ls\r\n84112 bhnt.gjg\r\n18231 gzrgd.vvj\r\ndir ntvmrrd\r\n234773 rcfbjzj\r\n281805 sdmmmds.nwt\r\n267837 zzdpcnmt.qbf\r\n$ cd ntvmrrd\r\n$ ls\r\n46209 lwvvwd.rtg\r\n$ cd ..\r\n$ cd ..\r\n$ cd mpqtgd\r\n$ ls\r\n99833 qbpvrr\r\n$ cd ..\r\n$ cd zpct\r\n$ ls\r\ndir bddslhrg\r\n272296 znffshsg.jrt\r\n$ cd bddslhrg\r\n$ ls\r\n81585 vjchlsrc.cmh\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd pjm\r\n$ ls\r\n147674 rbctzb\r\n$ cd ..\r\n$ cd qjj\r\n$ ls\r\n21770 wtht.fpd\r\n$ cd ..\r\n$ cd ..\r\n$ cd hfftvmw\r\n$ ls\r\ndir bhvzrsv\r\n130208 cclgndpd\r\ndir fzjdz\r\n39285 jtmcp.pjv\r\ndir mbgvdmpp\r\ndir tchbjclg\r\n202920 vjchlsrc.cmh\r\n$ cd bhvzrsv\r\n$ ls\r\n167049 bts\r\ndir mjjj\r\n257434 qsrpmshg\r\n279724 sdmmmds.nwt\r\n149934 snpb.zwq\r\n254808 tqcgmwbj.bcn\r\ndir wgf\r\n$ cd mjjj\r\n$ ls\r\ndir mrlvp\r\n$ cd mrlvp\r\n$ ls\r\n197237 pmwjbf.lmn\r\n$ cd ..\r\n$ cd ..\r\n$ cd wgf\r\n$ ls\r\n77157 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd ..\r\n$ cd fzjdz\r\n$ ls\r\n77499 mjjj.pdq\r\ndir shrpdcg\r\n180282 zzdpcnmt.qbf\r\n$ cd shrpdcg\r\n$ ls\r\n22528 bddslhrg\r\n191369 mjjj.llb\r\n35213 sdmmmds.nwt\r\n131772 spfmhdpf.wtr\r\n284434 tpzg.qjg\r\n$ cd ..\r\n$ cd ..\r\n$ cd mbgvdmpp\r\n$ ls\r\n220250 fsdzqhc.ljm\r\n101355 vnrcwb\r\n$ cd ..\r\n$ cd tchbjclg\r\n$ ls\r\n113952 gjbp.qgs\r\n$ cd ..\r\n$ cd ..\r\n$ cd jlftgw\r\n$ ls\r\ndir bddslhrg\r\n210047 cdbch\r\ndir dvrb\r\n266336 fhvwlg\r\n139851 qfccg.crl\r\ndir rcqhb\r\n176510 vjchlsrc.cmh\r\ndir wfrjg\r\n$ cd bddslhrg\r\n$ ls\r\n78175 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd dvrb\r\n$ ls\r\n216103 fzjdz.blg\r\n$ cd ..\r\n$ cd rcqhb\r\n$ ls\r\n39727 cgfjm.dpt\r\ndir pwb\r\n$ cd pwb\r\n$ ls\r\n39040 sdmmmds.nwt\r\n$ cd ..\r\n$ cd ..\r\n$ cd wfrjg\r\n$ ls\r\n206877 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd ..\r\n$ cd nnpvwtvt\r\n$ ls\r\n264455 czrjz\r\ndir nfdv\r\ndir nmcp\r\n113232 pffgw.hbv\r\ndir qrzlrt\r\n$ cd nfdv\r\n$ ls\r\ndir fpldng\r\ndir jhj\r\n56720 ltv\r\n170870 rgvs.ggh\r\n$ cd fpldng\r\n$ ls\r\n157283 vzv.qrq\r\n$ cd ..\r\n$ cd jhj\r\n$ ls\r\n172487 qpfh.lpr\r\n$ cd ..\r\n$ cd ..\r\n$ cd nmcp\r\n$ ls\r\n273633 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd qrzlrt\r\n$ ls\r\n111080 bddslhrg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qfstpm\r\n$ ls\r\n92950 hjr.zjn\r\n252254 sdmmmds.nwt\r\n$ cd ..\r\n$ cd sbprmc\r\n$ ls\r\ndir bddslhrg\r\n158704 bgnt.vbd\r\ndir cddp\r\ndir cpf\r\ndir hfns\r\n276655 phcccdq\r\ndir qbpvrr\r\ndir srjpcj\r\n55405 vhb.mbj\r\n$ cd bddslhrg\r\n$ ls\r\n238260 mjjj\r\n$ cd ..\r\n$ cd cddp\r\n$ ls\r\n87685 fzjdz.sbz\r\n$ cd ..\r\n$ cd cpf\r\n$ ls\r\ndir tchbjclg\r\n$ cd tchbjclg\r\n$ ls\r\ndir wjcvfvz\r\n$ cd wjcvfvz\r\n$ ls\r\n280711 svmf.czw\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd hfns\r\n$ ls\r\ndir bbjnrhf\r\ndir cvjtpc\r\n101075 ddbml.vff\r\ndir gdlqtlv\r\n157960 mswfp.wcj\r\n187182 qddfchn.dpg\r\n59533 rfjvzcq\r\n47332 wszmlq.nbt\r\n$ cd bbjnrhf\r\n$ ls\r\n269590 dgmjpzcz\r\ndir mjjj\r\n84955 mjjj.jqn\r\ndir mwqvvsnt\r\ndir qbpvrr\r\ndir qtdmwqcj\r\n131930 tqcgmwbj.bcn\r\ndir vvwb\r\n$ cd mjjj\r\n$ ls\r\ndir hvvh\r\n$ cd hvvh\r\n$ ls\r\n235980 vmmvp.sbh\r\n$ cd ..\r\n$ cd ..\r\n$ cd mwqvvsnt\r\n$ ls\r\n242698 mjjj.qbm\r\n15137 rncwrgjl.jfr\r\n158528 sdmmmds.nwt\r\n$ cd ..\r\n$ cd qbpvrr\r\n$ ls\r\ndir gpc\r\n$ cd gpc\r\n$ ls\r\n184310 lqfgplfg\r\n$ cd ..\r\n$ cd ..\r\n$ cd qtdmwqcj\r\n$ ls\r\n30238 cfpng.fnl\r\n284340 gst\r\ndir lvcjcglg\r\n82263 twmnlqcq\r\n78023 zzdpcnmt.qbf\r\n$ cd lvcjcglg\r\n$ ls\r\n225027 lsdrg.wqv\r\n$ cd ..\r\n$ cd ..\r\n$ cd vvwb\r\n$ ls\r\n184590 trg.vmc\r\n156231 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd ..\r\n$ cd cvjtpc\r\n$ ls\r\ndir whqnlc\r\n$ cd whqnlc\r\n$ ls\r\n66362 jnsprdt.vrs\r\ndir tchbjclg\r\ndir zhw\r\n$ cd tchbjclg\r\n$ ls\r\n227846 vqjtc.pld\r\n$ cd ..\r\n$ cd zhw\r\n$ ls\r\ndir bgwcrp\r\n$ cd bgwcrp\r\n$ ls\r\n114175 dftv\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd gdlqtlv\r\n$ ls\r\n121215 gbltpcv.prz\r\n41387 tqcgmwbj.bcn\r\n$ cd ..\r\n$ cd ..\r\n$ cd qbpvrr\r\n$ ls\r\n79921 tqcgmwbj.bcn\r\n263185 vjchlsrc.cmh\r\n$ cd ..\r\n$ cd srjpcj\r\n$ ls\r\n106650 fzjdz.tdf\r\n135245 qfccg.crl\r\n97014 tvlmvqm\r\n$ cd ..\r\n$ cd ..\r\n$ cd svbnljr\r\n$ ls\r\n286919 lwvw.zlr\r\n$ cd ..\r\n$ cd tchbjclg\r\n$ ls\r\ndir bljmjwm\r\ndir hsjww\r\ndir ptfsh\r\ndir qbpvrr\r\n147832 qfccg.crl\r\n$ cd bljmjwm\r\n$ ls\r\ndir cqtmhzbf\r\ndir mfpcdbg\r\ndir qlzg\r\ndir qtdh\r\ndir tbdff\r\ndir tchbjclg\r\n211603 zhr.gwl\r\n$ cd cqtmhzbf\r\n$ ls\r\ndir mmbgqlm\r\n150758 tqcgmwbj.bcn\r\ndir ztcbmbw\r\n$ cd mmbgqlm\r\n$ ls\r\n93439 bddslhrg.gnm\r\n25644 qbpvrr.jhm\r\n$ cd ..\r\n$ cd ztcbmbw\r\n$ ls\r\ndir cmwwg\r\ndir stgmndfd\r\n$ cd cmwwg\r\n$ ls\r\n239158 bfl.pwl\r\ndir dbvnwz\r\n17700 pqtpmpp\r\ndir tchbjclg\r\n$ cd dbvnwz\r\n$ ls\r\n217821 bzgsbc.zzp\r\n$ cd ..\r\n$ cd tchbjclg\r\n$ ls\r\ndir tpdtglwp\r\n52714 vjchlsrc.cmh\r\n111040 zzdpcnmt.qbf\r\n$ cd tpdtglwp\r\n$ ls\r\n287567 jmddscd\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd stgmndfd\r\n$ ls\r\n38426 bll.pww\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd mfpcdbg\r\n$ ls\r\ndir trjgzcj\r\n$ cd trjgzcj\r\n$ ls\r\ndir hngr\r\n268655 lgrwtch\r\n258843 pbpnjf.tmg\r\n100112 qbh\r\n72784 qbpvrr.cpg\r\ndir vbmqtf\r\n197735 vjchlsrc.cmh\r\n$ cd hngr\r\n$ ls\r\n82873 cwbmqp.llb\r\n261780 hsgwfv.pfn\r\n42859 ljt\r\ndir tchbjclg\r\n$ cd tchbjclg\r\n$ ls\r\ndir fhsgvttf\r\n253131 gtghn\r\ndir nzpcvjhp\r\ndir tpqrqtqj\r\n$ cd fhsgvttf\r\n$ ls\r\n56727 mjjj.vzf\r\n$ cd ..\r\n$ cd nzpcvjhp\r\n$ ls\r\ndir bddslhrg\r\ndir blhrls\r\n$ cd bddslhrg\r\n$ ls\r\n242433 vpvpqtqb.dfr\r\n$ cd ..\r\n$ cd blhrls\r\n$ ls\r\n110313 fzjdz.qtf\r\n$ cd ..\r\n$ cd ..\r\n$ cd tpqrqtqj\r\n$ ls\r\ndir dfjmpvj\r\n114636 gmqqrtv\r\ndir mjjj\r\n175067 wggfznff\r\n$ cd dfjmpvj\r\n$ ls\r\n174485 sjzg\r\n$ cd ..\r\n$ cd mjjj\r\n$ ls\r\n111397 pslm.fjf\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd vbmqtf\r\n$ ls\r\n151429 tchbjclg.tzm\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qlzg\r\n$ ls\r\n127640 bddslhrg.wbj\r\ndir fzjdz\r\ndir ghllcw\r\n62733 qfccg.crl\r\n96986 qwgh\r\n268380 vjchlsrc.cmh\r\n$ cd fzjdz\r\n$ ls\r\n153535 gcjss\r\n$ cd ..\r\n$ cd ghllcw\r\n$ ls\r\ndir fzjdz\r\ndir hwfm\r\n2536 jglh.njg\r\ndir mjjj\r\ndir mlhwcg\r\n200842 qfccg.crl\r\ndir tchbjclg\r\n246542 tqcgmwbj.bcn\r\ndir tqtsl\r\ndir vpn\r\n$ cd fzjdz\r\n$ ls\r\n124920 jzsbrwj\r\ndir wtvfgcrq\r\n$ cd wtvfgcrq\r\n$ ls\r\ndir ltnzjbl\r\n187917 mjjj.svp\r\ndir nvgrzrbr\r\ndir pngcwl\r\n$ cd ltnzjbl\r\n$ ls\r\n151460 jmc.zjf\r\n252590 tchbjclg\r\n$ cd ..\r\n$ cd nvgrzrbr\r\n$ ls\r\n193994 qbpvrr.tsv\r\n152776 tchbjclg.swm\r\n243770 vqzs.hjp\r\n$ cd ..\r\n$ cd pngcwl\r\n$ ls\r\n74603 bddslhrg\r\n288915 vjchlsrc.cmh\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd hwfm\r\n$ ls\r\ndir qbpvrr\r\n92630 vjchlsrc.cmh\r\n$ cd qbpvrr\r\n$ ls\r\ndir vlwbhgnv\r\n$ cd vlwbhgnv\r\n$ ls\r\n5248 tchbjclg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd mjjj\r\n$ ls\r\n255751 qfccg.crl\r\n$ cd ..\r\n$ cd mlhwcg\r\n$ ls\r\n115287 pfmch.ncr\r\n$ cd ..\r\n$ cd tchbjclg\r\n$ ls\r\ndir jgrmrzlh\r\n155900 jpljl.fnw\r\n$ cd jgrmrzlh\r\n$ ls\r\ndir mjjj\r\n96116 qbpvrr\r\n270714 tqcgmwbj.bcn\r\n$ cd mjjj\r\n$ ls\r\n59415 dpdgtz\r\n47363 twghmhf.qhf\r\n194434 vbnppl.fws\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd tqtsl\r\n$ ls\r\n34243 qqf\r\n131945 qtplsbwd\r\n$ cd ..\r\n$ cd vpn\r\n$ ls\r\n286479 sdmmmds.nwt\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qtdh\r\n$ ls\r\n215668 nhfpn\r\n$ cd ..\r\n$ cd tbdff\r\n$ ls\r\n48347 qfccg.crl\r\n178091 vbsqcnmm\r\n$ cd ..\r\n$ cd tchbjclg\r\n$ ls\r\ndir bddslhrg\r\ndir cwn\r\n251313 hll.ctt\r\ndir qbpvrr\r\ndir scsp\r\n$ cd bddslhrg\r\n$ ls\r\ndir pqtj\r\n185542 qbpvrr\r\ndir tchbjclg\r\n$ cd pqtj\r\n$ ls\r\n141015 jtwpnb.wvf\r\n17260 lgvbns.pvt\r\n$ cd ..\r\n$ cd tchbjclg\r\n$ ls\r\ndir btsmnvn\r\n237149 hhgbtf.zzs\r\n258581 lwvfgbdj.gpp\r\n31561 mjjj\r\n240514 qbwq\r\n90283 qfccg.crl\r\n$ cd btsmnvn\r\n$ ls\r\ndir bddslhrg\r\ndir qbpvrr\r\n$ cd bddslhrg\r\n$ ls\r\n144007 tchbjclg.qql\r\n$ cd ..\r\n$ cd qbpvrr\r\n$ ls\r\n211075 mjjj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd cwn\r\n$ ls\r\n67908 gldrw\r\n231112 qbpvrr\r\n$ cd ..\r\n$ cd qbpvrr\r\n$ ls\r\n4482 fzjdz.lzr\r\n134244 rnscgpv.tvg\r\n211213 tmvzclz.mjg\r\n107771 wvzs.nns\r\n$ cd ..\r\n$ cd scsp\r\n$ ls\r\n30654 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd hsjww\r\n$ ls\r\n12233 crzr.jrf\r\ndir qbpvrr\r\n$ cd qbpvrr\r\n$ ls\r\ndir bddslhrg\r\n54681 fzjdz.wzv\r\n212670 hpmzrq\r\ndir mcvbjw\r\n138779 nhsdjmjj.szh\r\ndir nllvlzfr\r\n217275 tqcgmwbj.bcn\r\n$ cd bddslhrg\r\n$ ls\r\n261081 lbdqrjjp.ffj\r\n244506 wvn.ttr\r\n55843 zbng.zmm\r\n$ cd ..\r\n$ cd mcvbjw\r\n$ ls\r\n149468 rcvbqhh\r\n$ cd ..\r\n$ cd nllvlzfr\r\n$ ls\r\n162791 rdrhrnzc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ptfsh\r\n$ ls\r\n163959 bddslhrg.wwb\r\ndir hthjj\r\ndir hwpv\r\n222930 ndvqsfbs.rfb\r\ndir rgrcfr\r\ndir rvrsrfl\r\n95254 tqcgmwbj.bcn\r\n282463 vjchlsrc.cmh\r\n181699 zzdpcnmt.qbf\r\n$ cd hthjj\r\n$ ls\r\n101683 dthb.hwv\r\n112759 mjmdfgl.vdz\r\n191795 whtfg\r\n$ cd ..\r\n$ cd hwpv\r\n$ ls\r\n244334 fzjdz.pgp\r\n$ cd ..\r\n$ cd rgrcfr\r\n$ ls\r\ndir wpslpf\r\n$ cd wpslpf\r\n$ ls\r\n87578 mjjj\r\n$ cd ..\r\n$ cd ..\r\n$ cd rvrsrfl\r\n$ ls\r\ndir qbpvrr\r\n$ cd qbpvrr\r\n$ ls\r\ndir gqv\r\ndir hfg\r\ndir lpbc\r\ndir ppp\r\n16805 snlhrz\r\n29365 wnd.mdj\r\n$ cd gqv\r\n$ ls\r\n229300 tqcgmwbj.bcn\r\n$ cd ..\r\n$ cd hfg\r\n$ ls\r\n1680 hcmmjtbq.wcv\r\n$ cd ..\r\n$ cd lpbc\r\n$ ls\r\n100372 lqf\r\n88156 sddtdz\r\n$ cd ..\r\n$ cd ppp\r\n$ ls\r\n79608 tchbjclg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qbpvrr\r\n$ ls\r\n22955 zzdpcnmt.qbf\r\n$ cd ..\r\n$ cd ..\r\n$ cd wtm\r\n$ ls\r\n4584 qfccg.crl\r\n$ cd ..\r\n$ cd ztrz\r\n$ ls\r\n187968 fzjdz.thw";

//string inputs = "$ cd /\r\n$ ls\r\ndir a\r\n14848514 b.txt\r\n8504156 c.dat\r\ndir d\r\n$ cd a\r\n$ ls\r\ndir e\r\n29116 f\r\n2557 g\r\n62596 h.lst\r\n$ cd e\r\n$ ls\r\n584 i\r\n$ cd ..\r\n$ cd ..\r\n$ cd d\r\n$ ls\r\n4060174 j\r\n8033020 d.log\r\n5626152 d.ext\r\n7214296 k";

List<FileSystemItem> items = new List<FileSystemItem>() { new Directory("/", null) };
var CurrentDirectory = items.OfType<Directory>().First();

void ExecuteCommand(string command, string param)
{
    if (command == "ls")
        return;

    if (param == "..")
    {
        if (CurrentDirectory.Parent != null)
            CurrentDirectory = CurrentDirectory.Parent;
    }
    else
    {
        if (param != "/")
            CurrentDirectory = CurrentDirectory.Child.OfType<Directory>().First(d => d.Name == param);
    }
}

void CreateDirectory(string name)
{
    var newDirectory = new Directory(name, CurrentDirectory);
    CurrentDirectory.Child.Add(newDirectory);
    items.Add(newDirectory);
}

void CreateFile(string size, string name)
{
    var newFile = new File(name, int.Parse(size), CurrentDirectory.Name);
    CurrentDirectory.Child.Add(newFile);
    items.Add(newFile);
}


foreach (var line in inputs.Split("\r\n").Select( l => l.Split(" ")))
{
    switch (line[0])
    {
        case "$":
            ExecuteCommand(line[1], line.Length > 2 ? line[2] : "");
            break;
        case "dir":
            CreateDirectory(line[1]);
            break;
        case string value when Char.IsNumber(value[0]):
            CreateFile(line[0], line[1]);
            break;
        default:
            throw new Exception("Mince alors");
    }
}


var result1 = items.OfType<Directory>().Where(d => d.Size <= 100000).Sum(d => d.Size);
Console.WriteLine(result1);

var sizedUsed = items.OfType<Directory>().First(d => d.Name == "/").Size;

int spaceNeededToDelete = 30000000 - (70000000 - sizedUsed);
var result2 = items.OfType<Directory>().Where(d => d.Size >= spaceNeededToDelete).OrderBy(d => d.Size).First().Size;
Console.WriteLine(result2);

// 70000000
// 30000000
// 48381165


//48381165
//24933642





