USE QUANLYTAISAN
GO

-- INSERT BẢNG NhomGiaoDich
INSERT INTO NhomGiaoDich(ten_nhom_gd) VALUES
(N'Đi vay/Cho vay'),
(N'Khoản chi'),
(N'Khoản thu'),
(N'Mua/Bán tài sản')
GO



-- INSERT BẢNG NhomGiaoDich
INSERT INTO LoaiGiaoDich(ma_nhom_gd, ten_loai_gd) VALUES
(1, N'Cho vay'), 
(1, N'Trả nợ'), --
(1, N'Đi vay'), -- 
(1, N'Thu nợ'), -- 
-------------------
(2, N'Ăn uống'),
(2, N'Hóa đơn & tiện ích'),
(2, N'Di chuyển'),
(2, N'Mua sắm'),
(2, N'Bạn bè & người yêu'),
(2, N'Giải trí'),
(2, N'Du lịch'),
(2, N'Sức khỏe'),
(2, N'Tặng quà & quyên góp'),
(2, N'Gia đình'),
(2, N'Giáo dục'),
(2, N'Đầu tư/Kinh doanh'),
(2, N'Khoản chi khác'),
-------------------
(3, N'Lương'),
(3, N'Thưởng'),
(3, N'Tiền lãi'),
(3, N'Được tặng'),
(3, N'Khoản thu khác'),
-------------------
(4, N'Mua'),
(4, N'Bán')
GO