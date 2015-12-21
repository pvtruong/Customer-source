CREATE TABLE [dbo].[diemdanh](
	[ma_lop] [varchar](32) NOT NULL,
	[ma_the] [varchar](128) NOT NULL,
	[ngay_ct] [date] NOT NULL,
	[ngay_tao] [datetime] NULL,
 CONSTRAINT [PK_diemdanh] PRIMARY KEY CLUSTERED 
(
	[ma_lop] ASC,
	[ma_the] ASC,
	[ngay_ct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

create proc cdiemdanh
	@ma_the varchar(129),
	@ma_lop varchar(129)
as
begin
	declare @ngay_ct date
	select @ngay_ct = getdate()
	declare @so_buoi_da_tap numeric(18,0)
	set @so_buoi_da_tap =0
	if exists(select * from dpcl where so_ct = @ma_lop and ma_the = @ma_the and @ngay_ct between tu_ngay and den_ngay) 
		begin
			delete from diemdanh where ma_lop = @ma_lop and ma_the = @ma_the and ngay_ct = @ngay_ct
			insert into diemdanh (ma_lop,ma_the,ngay_ct,ngay_tao) values (@ma_lop,@ma_the,@ngay_ct,getdate())
			--get thong tin khach hang
			
			select @so_buoi_da_tap = count(ngay_ct) from diemdanh
			 where ma_lop = @ma_lop and ma_the = @ma_the

			select *,@so_buoi_da_tap as so_buoi_da_tap, (so_buoi_tap - @so_buoi_da_tap) as so_buoi_con_lai from vdmthekhachhang
			where ma_the = @ma_the
		end
	else
		select *,@so_buoi_da_tap as so_buoi_da_tap, (so_buoi_tap - @so_buoi_da_tap) as so_buoi_con_lai from vdmthekhachhang
			where 1=0
end
GO
INSERT INTO gridinfo (gridid,columnsv,columnse,headersv,headerse,widths,formats,readonlys,hides,defaultvalues,carrys ) VALUES ( N'diemdanh', N'ma_the,ten_kh,so_buoi_tap,so_buoi_da_tap,so_buoi_con_lai,hieu_luc_tu,hieu_luc_den', N'ma_the,ten_kh,so_buoi_tap,so_buoi_da_tap,so_buoi_con_lai,hieu_luc_tu,hieu_luc_den', N'Mã thẻ,Tên khách hàng,Số buổi tập,Số buổi đã tập,Số buổi còn lại,Từ ngày,Đến ngày', N'Mã thẻ,tên khách hàng,Số buổi tập,Sd,CL,Từ ngày,Đến ngày', N'100,100,100,100,100,100,100', N',,f_tien,f_tien,f_tien,,', N'1,1,1,1,1,1,1', N'0,0,0,0,0,0,0', N',,,,,,', N'0,0,0,0,0,0,0' )