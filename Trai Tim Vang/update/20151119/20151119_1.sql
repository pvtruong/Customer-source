create view vdmthekhachhang
as
select a.*,b.ten_kh,b.dia_chi,b.dien_thoai
from dmthekhachhang a left join dkh b on a.ma_kh = b.ma_kh