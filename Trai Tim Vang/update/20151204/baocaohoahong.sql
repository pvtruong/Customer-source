create proc baocaohoahong
	@tu_ngay date,@den_ngay date,
	@ma_nv nvarchar(16)=''
as
	--chi tiet
	select 1 as sysorder,cast(0 as bit) as bold,a.ma_nv,b.ten_nv
		,sum(a.tien) as tien,sum(a.tien_hh) as tien_hh
	into #report
	from vdpt1 a left join dnv b on a.ma_nv = b.ma_nv
	where ngay_ct between @tu_ngay and @den_ngay
		and (@ma_nv ='' or a.ma_nv = @ma_nv)
	group by a.ma_nv,b.ten_nv
	--dong tong cong
	insert into #report(sysorder,bold,ma_nv,ten_nv,tien,tien_hh)
	select 5,1,'',N'Tổng cộng',sum(tien),sum(tien_hh) from #report
	--ket qua
	select * from #report order by sysorder

GO
INSERT INTO rpts (code,stt,name,name2,title0,title2,rpt,rpt_chart,store,pilotcolumn,pilotrow,pilotdata,pilotheader,pilotheader2,pilotwidth,pilotformat,pilotreadonly,gridid,tbform,idform,line_min,user_permit_print1,user_permit_print12,so_lien,ten_lien1,ten_lien2,ten_lien3,ten_lien4,ten_lien5,ten_lien6,ten_lien7,ten_lien8,ten_lien9,ngay_tao,nguoi_tao,ngay_sua,nguoi_sua,trang_thai,logo,mau_so ) VALUES ( N'baocaohoahong', N'1', N'Hoa hồng theo nhân viên', N'Hoa hồng theo nhân viên', N'Hoa hồng theo nhân viên', N'Hoa hồng theo nhân viên', N'baocaohoahong', N'', N'baocaohoahong', N'', N'', N'', N'', N'', N'', N'', N'', N'baocaohoahong', N'', N'', N'1', N'', N'', N'1', N'', N'', N'', N'', N'', N'', N'', N'', N'', Null, N'', Null, N'', 0, Null, N'' )
GO
INSERT INTO command (id,id0,Title0,Title1,exe,Image,type,hide_yn,ma_cn,toolbar_yn,ghi_chu,ghi_chu2,lien_quan,menu_yn,web_yn,web_title,p3_yn ) VALUES ( N'30.20.90', N'30.20.00', N'Báo cáo hoa hồng theo nhân viên', N'Báo cáo hoa hồng theo nhân viên', N'baocaohoahong.exe', N'Report.png', N'R', 0, N'baocaohoahong', 0, '', '', N'', 0, 0, N'', 0 )
GO
INSERT INTO gridinfo (gridid,columnsv,columnse,headersv,headerse,widths,formats,readonlys,hides,defaultvalues,carrys ) VALUES ( N'baocaohoahong', N'ma_nv,ten_nv,tien,tien_hh', N'ma_nv,ten_nv,tien,tien_hh', N'Mã nhân viên,Tên nhân viên,Tiền,Tiền hoa hồng', N'Mã nhân viên,Tên nhân viên,Tiền,Tiền hh', N'100,200,100,100', N',,f_tien,f_tien', N'1,1,1,1', N'0,0,0,0', N',,,', N'0,0,0,0' )