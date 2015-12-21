
CREATE TABLE [dbo].[dmthekhachhang](
	[ma_the] [varchar](32) NOT NULL,
	[ma_kh] [varchar](32) NOT NULL,
	[so_buoi_tap] [numeric](18, 5) NOT NULL,
	[gio_tap] [varchar](16) NOT NULL,
	[hieu_luc_tu] [datetime] NOT NULL,
	[hieu_luc_den] [datetime] NOT NULL,
	[ghi_chu] [nvarchar](128) NULL,
	[trang_thai] [bit] NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [char](16) NULL,
	[nguoi_sua] [char](16) NULL
 CONSTRAINT [PK_dmthekhachhang] PRIMARY KEY CLUSTERED 
(
	[ma_the] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[dmkhoahoc](
	[ma_khoa_hoc] [varchar](32) NOT NULL,
	[ten_khoa_hoc] [nvarchar](128) NULL,
	[hieu_luc_tu] [datetime] NOT NULL,
	[hieu_luc_den] [datetime] NOT NULL,
	[trang_thai] [bit] NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [char](16) NULL,
	[nguoi_sua] [char](16) NULL
 CONSTRAINT [PK_dmkhoahoc] PRIMARY KEY CLUSTERED 
(
	[ma_khoa_hoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO listinfo (listid,ctable,cview,gridid,inherit,showoldvalue,ma_qct,field_auto,allow_edit,title,title2,condition_copy,allow_change_code,grid4import,showtop,ma_phan_nhom ) VALUES ( N'dmthekhachhang', N'dmthekhachhang', N'vdmthekhachhang', N'dmthekhachhang', N'', 0, N'', N'', 1, N'Danh mục thể khách hàng', N'Danh mục thể khách hàng', N'1=1', 1, '', 20.00000, N'' )
INSERT INTO listinfo (listid,ctable,cview,gridid,inherit,showoldvalue,ma_qct,field_auto,allow_edit,title,title2,condition_copy,allow_change_code,grid4import,showtop,ma_phan_nhom ) VALUES ( N'dmkhoahoc', N'dmkhoahoc', N'dmkhoahoc', N'dmkhoahoc', N'', 0, N'', N'', 1, N'Danh mục khóa học', N'Danh mục khóa học', N'1=1', 1, '', 20.00000, N'' )
GO
INSERT INTO dmct (ma_ct,Ten_ct,Stt_rec_ht,so_ct_ht,kieu_trung_so_ct,exe,ma_ct_in,tieu_de_ct,stt_in,stt_ntxt,stt_ct_nkc,ten_ct2 ) VALUES ( N'PCL', N'Phiếu xếp lớp', 0.00000, N'0', N'1', N'vpcl.exe', N'PCL', N'Phiếu xếp lớp', N'49', N'0', N'50', N'Phiếu xếp lớp' )
INSERT INTO voucherdetailinfo (voucherid,stt,tablename,viewname,gridid4input,table4import,gridid4import,store4import,key4import,trang_thai,title,title2,not_empty,allow_copy,columns_ht,columns_nt,next_row_when_press_enter,index_name ) VALUES ( N'PCL', N'1', N'dpcl', N'vdpcl', N'dpcl', '', '', N'', N'', 1, N'Chi tiết', N'Detail', 1, 1, '', '', 0, '' )

delete  from voucherinfo where voucherid ='pcl'
INSERT INTO voucherinfo (voucherid,detailtable,mastertable,dgridid,mgridid,rownumber,mviewname,dviewname,formid,d_ma_gd,d_status,d_ma_nt,d_so_lien,trang_thai,check_ngay_ks,module,allow_edit_so_ct,HideDetailView,index_name ) VALUES ( N'PCL', N'dpcl', N'mpcl', N'dpcl', N'mpcl', 5.00000, N'vmpcl', N'vdpcl', N'PCL', N'0', N'0', N'VND', N'1', 1, 1, N'', 1, 0, N'' )

GO
INSERT INTO command (id,id0,Title0,Title1,exe,Image,type,hide_yn,ma_cn,toolbar_yn,ghi_chu,ghi_chu2,lien_quan,menu_yn,web_yn,web_title,p3_yn ) VALUES ( N'96.07.50', N'96.07.00', N'Danh mục thẻ khách hàng', N'Danh mục thẻ khách hàng', N'dmthekhachhang.exe', N'\capnhatdanhmuc\dm_tknh.png', N'L', 0, N'dmthekhachhang', 0, N'Danh mục thẻ khách hàng', N'Danh mục thẻ khách hàng', N'', 0, 0, N'', 0 )
INSERT INTO command (id,id0,Title0,Title1,exe,Image,type,hide_yn,ma_cn,toolbar_yn,ghi_chu,ghi_chu2,lien_quan,menu_yn,web_yn,web_title,p3_yn ) VALUES ( N'96.07.51', N'96.07.00', N'Danh mục khóa học', N'Danh mục khóa học', N'dmkhoahoc.exe', N'\capnhatdanhmuc\dm_tknh.png', N'L', 0, N'dmkhoahoc', 0, N'Danh mục khóa học', N'Danh mục khóa học', N'', 0, 0, N'', 0 )


INSERT INTO command (id,id0,Title0,Title1,exe,Image,type,hide_yn,ma_cn,toolbar_yn,ghi_chu,ghi_chu2,lien_quan,menu_yn,web_yn,web_title,p3_yn ) VALUES ( N'40.10.00', N'40.00.00', N'Quản lý lớp học', N'Quản lý lớp học', N'', N'\KTbanhang\process.png', N'', 0, N'', 0, N'Quản lý lớp học', N'Quản lý lớp học', N'', 0, 0, N'', 0 )
INSERT INTO command (id,id0,Title0,Title1,exe,Image,type,hide_yn,ma_cn,toolbar_yn,ghi_chu,ghi_chu2,lien_quan,menu_yn,web_yn,web_title,p3_yn ) VALUES ( N'40.10.05', N'40.10.00', N'Xếp lớp học', N'Xếp lớp học', N'vpcl.exe', N'\KTbanhang\allocated.png', N'V', 0, N'PCL', 0, N'Xếp lớp học', N'Xếp lớp học', N'', 0, 0, N'', 0 )
GO

INSERT INTO gridinfo (gridid,columnsv,columnse,headersv,headerse,widths,formats,readonlys,hides,defaultvalues,carrys ) VALUES ( N'dmthekhachhang', N'ma_the,ma_kh,ten_kh,so_buoi_tap,gio_tap,hieu_luc_tu,hieu_luc_den', N'ma_the,ma_kh,ten_kh,so_buoi_tap,gio_tap,hieu_luc_tu,hieu_luc_den', N'Mã thẻ,Mã khách,Tên khách,Số buổi,Giờ tập,Từ ngày,Đến ngày', N'Mã thẻ,Mã khách,Tên khách,Số buổi,Giờ tập,Từ ngày,Đến ngày', N'100,100,200,100,100,100,100', N',,,f_tien,,,', N'1,1,1,1,1,1,1', N'0,0,0,0,0,0,0', N',,,,,,', N'0,0,0,0,0,0,0' )
GO
INSERT INTO formlookup (formid,codelookup,control,field,notempty,lookupyn,MultiValue,ckey,FieldRecName,FieldrecData,FieldrecData2,not_isnullable_when,readonly_when,min_words,always_refresh_suggest ) VALUES ( N'dmthekhachhang', N'dmkh', N'txtma_kh', N'ma_kh', 1, 1, 0, N'1=1', N'txtma_kh,ten_kh', N'ma_kh,ten_kh', N'ma_kh,ten_kh', '', '', N'3', 0 )
GO

INSERT INTO gridinfo (gridid,columnsv,columnse,headersv,headerse,widths,formats,readonlys,hides,defaultvalues,carrys ) VALUES ( N'dmkhoahoc', N'ma_khoa_hoc,ten_khoa_hoc,hieu_luc_tu,hieu_luc_den', N'ma_khoa_hoc,ten_khoa_hoc,hieu_luc_tu,hieu_luc_den', N'Mã khóa học,Tên khóa học,Từ ngày,Đến ngày', N'Mã khóa học,Tên khóa học,Hiệu lực từ,Hiệu lực đến', N'100,200,100,100', N',,,', N'1,1,1,1', N'0,0,0,0', N',,,', N'0,0,0,0' )
GO

INSERT INTO dmitemofcbb (Form,Name,Inds,Text,Text2,print_yn,imp_yn,val,val2 ) VALUES ( N'PCL', N'Status', N'0', N'Lập chứng từ', N'Making voucher', 1, 1, N'', N'' )