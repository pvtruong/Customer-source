
CREATE TABLE [dbo].[Dpcl](
	[stt_rec] [char](13) NOT NULL,
	[ma_ct] [char](3) NULL,
	[ngay_ct] [smalldatetime] NULL,
	[so_ct] [char](16) NULL,
	[dien_giai] [nvarchar](128) NULL,

	[ma_kh] [char](16) NULL,
	[ma_the] [char](16) NULL,
	
	[so_buoi_tap] [numeric](5, 0) NULL,
	[gio_tap] [varchar](16) NULL,

	[tu_ngay] [datetime] NULL,
	[den_ngay] [datetime] NULL,

	[line] [numeric](5, 0) NULL,
	[ma_sp] [varchar](16) NULL,
	[so_lsx] [varchar](16) NULL,
	[so_hd] [varchar](16) NULL,
	[ma_nvu] [varchar](16) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Dpcl]  WITH NOCHECK ADD  CONSTRAINT [FK_dpcl_Mpcl] FOREIGN KEY([stt_rec])
REFERENCES [dbo].[Mpcl] ([stt_rec])
GO

ALTER TABLE [dbo].[Dpcl] CHECK CONSTRAINT [FK_dpcl_Mpcl]
GO


create view vdpcl
as
select a.*,b.ten_kh
from dpcl a left join dkh b on a.ma_kh = b.ma_kh
	

GO
INSERT INTO formlookup (formid,codelookup,control,field,notempty,lookupyn,MultiValue,ckey,FieldRecName,FieldrecData,FieldrecData2,not_isnullable_when,readonly_when,min_words,always_refresh_suggest ) VALUES ( N'PCL', N'dmnv', N'txtma_nv', N'ma_nv', 0, 1, 0, N'1=1', N'txtma_nv,ten_nv', N'ma_nv,ten_nv', N'ma_nv,ten_nv', '', '', N'3', 0 )
INSERT INTO formlookup (formid,codelookup,control,field,notempty,lookupyn,MultiValue,ckey,FieldRecName,FieldrecData,FieldrecData2,not_isnullable_when,readonly_when,min_words,always_refresh_suggest ) VALUES ( N'PCL', N'dmkhoahoc', N'txtma_khoa_hoc', N'ma_khoa_hoc', 1, 1, 0, N'1=1', N'txtma_khoa_hoc,ten_khoa_hoc', N'ma_khoa_hoc,ten_khoa_hoc', N'ma_khoa_hoc,ten_khoa_hoc', N'', N'', N'3', 0 )
GO

INSERT INTO lookup (Code,cTable,cFields,cFinds,cKey,gridid,formid,exe_list,title,title2,ckey2,orderby ) VALUES ( N'dmkhoahoc', N'dmkhoahoc', N'ma_khoa_hoc,ten_khoa_hoc', N'ma_khoa_hoc,ten_khoa_hoc', N'1=1', N'dmkhoahoc', N'dmkhoahoc', N'dmkhoahoc.exe#dmkhoahoc', N'Danh mục khóa học', N'Danh mục khóa học', N'', N'' )
GO
delete from lookup where code ='dmthekhachhang'
INSERT INTO lookup (Code,cTable,cFields,cFinds,cKey,gridid,formid,exe_list,title,title2,ckey2,orderby ) VALUES ( N'dmthekhachhang', N'vdmthekhachhang', N'ma_the,ma_kh,ten_kh,dia_chi,dien_thoai,so_buoi_tap,gio_tap,hieu_luc_tu,hieu_luc_den', N'ma_the,ma_kh,ten_kh,dia_chi,dien_thoai', N'1=1', N'dmthekhachhang', N'dmthekhachhang', N'', N'Danh mục thẻ khách hàng', N'Danh mục thẻ khách hàng', N'', N'' )
GO

delete  from fieldlookup where code ='pcl'

INSERT INTO fieldlookup (code,tab,field,fieldlookups,fieldgrids,fieldlookups2,fieldgrids2,codelookup,isnullable,ckey,lookup_yn,not_isnullable_when,readonly_when,empty_when_readonly,multivalue,min_words,always_refresh_suggest ) VALUES ( N'PCL', N'vdpcl', N'ma_the', N'ma_the,ma_kh,ten_kh,so_buoi_tap,gio_tap,hieu_luc_tu,hieu_luc_den', N'ma_the,ma_kh,ten_kh,so_buoi_tap,gio_tap,tu_ngay,den_ngay', N'ma_the,ma_kh,ten_kh,so_buoi_tap,gio_tap,hieu_luc_tu,hieu_luc_den', N'ma_the,ma_kh,ten_kh,so_buoi_tap,gio_tap,tu_ngay,den_ngay', N'dmthekhachhang', 0, N'1=1', 1, N'', N'', 0, 0, N'3', 0 )