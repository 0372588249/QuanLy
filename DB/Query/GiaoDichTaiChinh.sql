SELECT NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd , GiaoDichTaiChinh.so_tien , COUNT(*)
                                FROM GiaoDichTaiChinh, TaiKhoan, VI, NguoiQuen, LoaiGiaoDich
                                WHERE TaiKhoan.taikhoan = VI.taikhoan
                                AND TaiKhoan.taikhoan = NguoiQuen.taikhoan

                                AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                                AND GiaoDichTaiChinh.ma_nguoi_quen = NguoiQuen.ma_nguoi_quen

                                AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd

                                AND TaiKhoan.taikhoan = 'admin'
                                AND NguoiQuen.ma_nguoi_quen != 13
                                GROUP BY NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd, GiaoDichTaiChinh.so_tien