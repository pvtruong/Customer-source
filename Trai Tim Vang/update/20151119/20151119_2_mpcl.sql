
CREATE TABLE [dbo].[Mpcl](
	[stt_rec] [char](13) NOT NULL,
	[ma_dvcs] [char](16) NULL,
	[ma_ct] [char](3) NULL,
	[ma_gd] [int] NULL,
	[ngay_ct] [datetime] NOT NULL,
	[so_ct] [char](16) NOT NULL,
	[dien_giai] [nvarchar](128) NULL,
	[ten_lop] [nvarchar](128) NOT NULL,
	
	[ma_nv] [varchar](16) NULL,
	[ma_khoa_hoc] [varchar](16) NOT NULL,
	
	[status] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [char](16) NULL,
	[nguoi_sua] [char](16) NULL,
	[ngay_xoa] [datetime] NULL,
	[nguoi_xoa] [char](16) NULL,
	[ma_nt] [nvarchar](3) NOT NULL,
	[ty_gia] [numeric](18, 5) NULL
 CONSTRAINT [PK_Mpcl] PRIMARY KEY CLUSTERED 
(
	[stt_rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
create view vmpcl
as
select a.*
from mpcl a

