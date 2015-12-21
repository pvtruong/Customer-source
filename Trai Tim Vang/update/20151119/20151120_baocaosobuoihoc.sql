create proc baocaosobuoihoc
	@den_ngay date,
	@ma_the varchar(32) ='',
	@ma_khoa_hoc varchar(32) ='',
	@ma_lop varchar(32)=''
as

begin
	--thong tin lop hoc
	select a.*,b.so_ct as ma_lop,b.ma_nv,b.ma_khoa_hoc,b.ten_lop

	into #lop
	from vdpcl  a left join vmpcl b on a.stt_rec = b.stt_rec 
	where a.den_ngay >= @den_ngay and a.tu_ngay <= @den_ngay
	and (@ma_the ='' or a.ma_the = @ma_the)
	and (@ma_khoa_hoc ='' or b.ma_khoa_hoc = @ma_khoa_hoc)
	and (@ma_lop ='' or b.so_ct = @ma_lop)
	--thong tin diem danh
	select ma_lop,ma_the,count(ngay_ct) as so_buoi_da_tap
	 into #diemdanh
	 from diemdanh
	 where ngay_ct <= @den_ngay
	 and (@ma_the ='' or ma_the = @ma_the)
	 and (@ma_lop ='' or ma_lop = @ma_lop)

	 group by   ma_lop,ma_the

	--ket qua
	select a.* ,isnull(b.so_buoi_da_tap,0) as so_buoi_da_tap,(a.so_buoi_tap-isnull(b.so_buoi_da_tap,0)) as so_buoi_con_lai
	from #lop a left join #diemdanh b on a.ma_the = b.ma_the and a.ma_lop = b.ma_lop
end

GO
INSERT INTO rpts (code,stt,name,name2,title0,title2,rpt,rpt_chart,store,pilotcolumn,pilotrow,pilotdata,pilotheader,pilotheader2,pilotwidth,pilotformat,pilotreadonly,gridid,tbform,idform,line_min,user_permit_print1,user_permit_print12,so_lien,ten_lien1,ten_lien2,ten_lien3,ten_lien4,ten_lien5,ten_lien6,ten_lien7,ten_lien8,ten_lien9,ngay_tao,nguoi_tao,ngay_sua,nguoi_sua,trang_thai,logo,mau_so ) VALUES ( N'baocaosobuoihoc', N'1', N'Báo cáo số buổi học', N'Báo cáo số buổi học', N'Báo cáo số buổi học', N'Báo cáo số buổi học', N'baocaosobuoihoc', N'', N'baocaosobuoihoc', N'', N'', N'', N'', N'', N'', N'', N'', N'baocaosobuoihoc', N'', N'', 0, N'', N'', N'1', N'', N'', N'', N'', N'', N'', N'', N'', N'', Null, N'', Null, N'', 1, Null, N'' )
GO
INSERT INTO command (id,id0,Title0,Title1,exe,Image,type,hide_yn,ma_cn,toolbar_yn,ghi_chu,ghi_chu2,lien_quan,menu_yn,web_yn,web_title,p3_yn ) VALUES ( N'40.10.09', N'40.10.00', N'Báo cáo số buổi học', N'Báo cáo số buổi học', N'baocaosobuoihoc.exe', N'\KTbanhang\allocated.png', N'R', 0, N'baocaosobuoihoc', 0, N'Báo cáo số buổi học', N'Báo cáo số buổi học', N'', 0, 0, N'', 0 )
GO

INSERT INTO gridinfo (gridid,columnsv,columnse,headersv,headerse,widths,formats,readonlys,hides,defaultvalues,carrys ) VALUES ( N'baocaosobuoihoc', N'ma_the,ten_kh,so_buoi_tap,so_buoi_da_tap,so_buoi_con_lai,tu_ngay,den_ngay,gio_tap,ma_lop,ten_lop', N'ma_the,ten_kh,so_buoi_tap,so_buoi_da_tap,so_buoi_con_lai,tu_ngay,den_ngay,gio_tap,ma_lop,ten_lop', N'Mã thẻ,Tên khách hàng,Số buổi tập,Số buổi đã tập,Số buổi còn lại,Từ ngày,Đến ngày,Giờ tập,Mã lớp,Tên lớp', N'Mã thẻ,Tên khách hàng,Số buổi tập,Số buổi đã tập,Còn lại,Từ ngày,Đến ngày,Giờ tập,Mã lớp,Tên lớp', N'100,200,100,100,100,100,100,100,100,100', N',,f_tien,f_tien,f_tien,,,,,', N'1,1,1,1,1,1,1,1,1,1', N'0,0,0,0,0,0,0,0,0,0', N',,,,,,,,,', N'0,0,0,0,0,0,0,0,0,0' )
GO

INSERT INTO formlookup (formid,codelookup,control,field,notempty,lookupyn,MultiValue,ckey,FieldRecName,FieldrecData,FieldrecData2,not_isnullable_when,readonly_when,min_words,always_refresh_suggest ) VALUES ( N'baocaosobuoihoc', N'dmthekhachhang', N'txtma_the', N'ma_the', 0, 1, 0, N'1=1', N'txtma_the,ten_kh', N'ma_the,ten_kh', N'ma_the,ten_kh', N'', N'', N'3', 0 )
INSERT INTO formlookup (formid,codelookup,control,field,notempty,lookupyn,MultiValue,ckey,FieldRecName,FieldrecData,FieldrecData2,not_isnullable_when,readonly_when,min_words,always_refresh_suggest ) VALUES ( N'baocaosobuoihoc', N'dmkhoahoc', N'txtma_khoa_hoc', N'ma_khoa_hoc', 0, 1, 0, N'1=1', N'txtma_khoa_hoc,ten_khoa_hoc', N'ma_khoa_hoc,ten_khoa_hoc', N'ma_khoa_hoc,ten_khoa_hoc', N'', N'', N'3', 0 )
INSERT INTO formlookup (formid,codelookup,control,field,notempty,lookupyn,MultiValue,ckey,FieldRecName,FieldrecData,FieldrecData2,not_isnullable_when,readonly_when,min_words,always_refresh_suggest ) VALUES ( N'baocaosobuoihoc', N'dmlophoc', N'txtma_lop', N'so_ct', 0, 1, 0, N'1=1', N'txtma_lop,ten_lop', N'so_ct,ten_lop', N'so_ct,ten_lop', N'', N'', N'3', 0 )
GO

INSERT INTO lookup (Code,cTable,cFields,cFinds,cKey,gridid,formid,exe_list,title,title2,ckey2,orderby ) VALUES ( N'dmlophoc', N'vmpcl', N'so_ct,ten_lop', N'so_ct,ten_lop', N'1=1', N'mpcl', N'pcl', N'', N'Danh mục lớp học', N'Danh mục lớp học', N'', N'' )
