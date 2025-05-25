-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th4 22, 2025 lúc 05:21 PM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `cosmeticshop`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `color`
--

CREATE TABLE `color` (
  `ColorID` int(11) NOT NULL,
  `ColorName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `color`
--

INSERT INTO `color` (`ColorID`, `ColorName`) VALUES
(1, 'Đỏ'),
(2, 'Hồng'),
(3, 'Cam'),
(4, 'Tím'),
(5, 'Nâu'),
(6, 'Be'),
(7, 'Trắng'),
(8, 'Xanh lá'),
(9, 'Xanh dương'),
(10, 'Đen');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `country`
--

CREATE TABLE `country` (
  `CountryID` int(11) NOT NULL,
  `CountryName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `country`
--

INSERT INTO `country` (`CountryID`, `CountryName`) VALUES
(1, 'Pháp'),
(2, 'Hàn Quốc'),
(3, 'Mỹ'),
(4, 'Nhật Bản'),
(5, 'Trung Quốc'),
(6, 'Đức'),
(7, 'Ý'),
(8, 'Anh'),
(9, 'Canada'),
(10, 'Úc');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(11) NOT NULL,
  `CustomerName` varchar(100) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `customer`
--

INSERT INTO `customer` (`CustomerID`, `CustomerName`, `Address`, `Phone`) VALUES
(1, 'Mai Lan', 'Hà Nội', '0911111111'),
(2, 'Minh Anh', 'Hồ Chí Minh', '0911111112'),
(3, 'Hoàng Tú', 'Đà Nẵng', '0911111113'),
(4, 'Ngọc Bích', 'Cần Thơ', '0911111114'),
(5, 'Anh Dũng', 'Huế', '0911111115'),
(6, 'Thu Hằng', 'Hải Phòng', '0911111116'),
(7, 'Hữu Tâm', 'Nha Trang', '0911111117'),
(8, 'Thủy Tiên', 'Vũng Tàu', '0911111118'),
(9, 'Đình Phúc', 'Biên Hòa', '0911111119'),
(10, 'Quỳnh Như', 'Quảng Nam', '0911111120');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `employee`
--

CREATE TABLE `employee` (
  `EmployeeID` int(11) NOT NULL,
  `EmployeeName` varchar(100) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `JobID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `employee`
--

INSERT INTO `employee` (`EmployeeID`, `EmployeeName`, `Gender`, `BirthDate`, `Phone`, `Address`, `JobID`) VALUES
(1, 'Nguyễn Văn A', 'Nam', '1990-01-01', '0900000001', 'Hà Nội', 1),
(2, 'Trần Thị B', 'Nữ', '1992-03-15', '0900000002', 'Hồ Chí Minh', 2),
(3, 'Lê Văn C', 'Nam', '1989-07-21', '0900000003', 'Đà Nẵng', 3),
(4, 'Phạm Thị D', 'Nữ', '1995-12-10', '0900000004', 'Hải Phòng', 4),
(5, 'Đỗ Văn E', 'Nam', '1991-09-30', '0900000005', 'Cần Thơ', 5),
(6, 'Ngô Thị F', 'Nữ', '1993-06-18', '0900000006', 'Huế', 6),
(7, 'Hoàng Văn G', 'Nam', '1990-11-11', '0900000007', 'Nha Trang', 7),
(8, 'Vũ Thị H', 'Nữ', '1988-08-08', '0900000008', 'Vũng Tàu', 8),
(9, 'Phan Văn I', 'Nam', '1996-05-25', '0900000009', 'Quảng Nam', 9),
(10, 'Bùi Thị J', 'Nữ', '1994-02-28', '0900000010', 'Biên Hòa', 10);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `importinvoice`
--

CREATE TABLE `importinvoice` (
  `ImportInvoiceID` int(11) NOT NULL,
  `EmployeeID` int(11) DEFAULT NULL,
  `ImportDate` date DEFAULT NULL,
  `SupplierID` int(11) DEFAULT NULL,
  `TotalAmount` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `importinvoice`
--

INSERT INTO `importinvoice` (`ImportInvoiceID`, `EmployeeID`, `ImportDate`, `SupplierID`, `TotalAmount`) VALUES
(1, 1, '2024-04-01', 1, 200000.00),
(2, 2, '2024-04-02', 2, 350000.00),
(3, 3, '2024-04-03', 3, 150000.00),
(4, 4, '2024-04-04', 4, 180000.00),
(5, 5, '2024-04-05', 5, 220000.00),
(6, 1, '2024-04-06', 2, 300000.00),
(7, 2, '2024-04-07', 3, 400000.00),
(8, 3, '2024-04-08', 4, 250000.00),
(9, 4, '2024-04-09', 5, 320000.00),
(10, 5, '2024-04-10', 1, 270000.00);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `importinvoicedetail`
--

CREATE TABLE `importinvoicedetail` (
  `ImportInvoiceID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `UnitPrice` decimal(12,2) DEFAULT NULL,
  `Discount` decimal(5,2) DEFAULT NULL,
  `Total` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `importinvoicedetail`
--

INSERT INTO `importinvoicedetail` (`ImportInvoiceID`, `ProductID`, `Quantity`, `UnitPrice`, `Discount`, `Total`) VALUES
(1, 1, 50, 40000.00, 0.00, 200000.00),
(2, 2, 100, 30000.00, 0.05, 285000.00),
(3, 3, 60, 25000.00, 0.00, 150000.00),
(4, 4, 40, 45000.00, 0.10, 162000.00),
(5, 5, 80, 30000.00, 0.08, 220800.00),
(6, 6, 70, 42000.00, 0.05, 279300.00),
(7, 7, 90, 50000.00, 0.00, 450000.00),
(8, 8, 50, 50000.00, 0.10, 225000.00),
(9, 9, 40, 90000.00, 0.20, 288000.00),
(10, 10, 30, 10000.00, 0.00, 300000.00);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `job`
--

CREATE TABLE `job` (
  `JobID` int(11) NOT NULL,
  `JobName` varchar(100) DEFAULT NULL,
  `Salary` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `job`
--

INSERT INTO `job` (`JobID`, `JobName`, `Salary`) VALUES
(1, 'Bán hàng', 5000000.00),
(2, 'Thu ngân', 5500000.00),
(3, 'Kho', 4500000.00),
(4, 'Quản lý', 10000000.00),
(5, 'Giao hàng', 4000000.00),
(6, 'Tư vấn', 6000000.00),
(7, 'IT', 8000000.00),
(8, 'Kế toán', 7000000.00),
(9, 'Bảo vệ', 3500000.00),
(10, 'Lễ tân', 4800000.00);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `manufacturer`
--

CREATE TABLE `manufacturer` (
  `ManufacturerID` int(11) NOT NULL,
  `ManufacturerName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `manufacturer`
--

INSERT INTO `manufacturer` (`ManufacturerID`, `ManufacturerName`) VALUES
(1, 'L\'Oreal'),
(2, 'Maybelline'),
(3, 'The Face Shop'),
(4, 'Innisfree'),
(5, 'Shiseido'),
(6, 'Estee Lauder'),
(7, 'Lancome'),
(8, 'MAC'),
(9, 'Chanel'),
(10, 'Clinique');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `material`
--

CREATE TABLE `material` (
  `MaterialID` int(11) NOT NULL,
  `MaterialName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `material`
--

INSERT INTO `material` (`MaterialID`, `MaterialName`) VALUES
(1, 'Dầu tự nhiên'),
(2, 'Chiết xuất trà xanh'),
(3, 'Bột khoáng'),
(4, 'Silicone'),
(5, 'Nước tinh khiết'),
(6, 'Vitamin E'),
(7, 'Collagen'),
(8, 'Aloe Vera'),
(9, 'Glycerin'),
(10, 'Acid Hyaluronic');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `product`
--

CREATE TABLE `product` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) NOT NULL,
  `TypeID` int(11) DEFAULT NULL,
  `UnitID` int(11) DEFAULT NULL,
  `ManufacturerID` int(11) DEFAULT NULL,
  `MaterialID` int(11) DEFAULT NULL,
  `UsageID` int(11) DEFAULT NULL,
  `SeasonID` int(11) DEFAULT NULL,
  `ColorID` int(11) DEFAULT NULL,
  `CountryID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `ImportPrice` decimal(12,2) DEFAULT NULL,
  `SalePrice` decimal(12,2) DEFAULT NULL,
  `WarrantyPeriod` varchar(50) DEFAULT NULL,
  `Image` text DEFAULT NULL,
  `Note` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `product`
--

INSERT INTO `product` (`ProductID`, `ProductName`, `TypeID`, `UnitID`, `ManufacturerID`, `MaterialID`, `UsageID`, `SeasonID`, `ColorID`, `CountryID`, `Quantity`, `ImportPrice`, `SalePrice`, `WarrantyPeriod`, `Image`, `Note`) VALUES
(1, 'Son môi đỏ Ruby', 1, 1, 1, 1, 1, 1, 1, 1, 100, 50000.00, 89000.00, '6 tháng', 'ruby.jpg', 'Son lì lâu trôi'),
(2, 'Kem dưỡng da ban đêm', 2, 2, 2, 2, 2, 2, 2, 2, 50, 120000.00, 199000.00, '12 tháng', 'cream.jpg', 'Dưỡng ẩm ban đêm'),
(3, 'Phấn phủ kiềm dầu', 3, 3, 3, 3, 3, 3, 3, 3, 75, 90000.00, 150000.00, '12 tháng', 'powder.jpg', 'Dành cho da dầu'),
(4, 'Toner hoa hồng', 4, 4, 4, 4, 4, 4, 4, 4, 40, 70000.00, 115000.00, '12 tháng', 'toner.jpg', 'Cân bằng độ pH da'),
(5, 'Kem chống nắng SPF50+', 5, 5, 5, 5, 5, 5, 5, 5, 90, 80000.00, 135000.00, '12 tháng', 'sunscreen.jpg', 'Chống nắng và dưỡng ẩm'),
(6, 'Mascara chống nước', 6, 6, 6, 6, 6, 6, 6, 6, 60, 60000.00, 109000.00, '6 tháng', 'mascara.jpg', 'Giữ mi cong suốt ngày'),
(7, 'Son dưỡng môi hương dâu', 7, 7, 7, 7, 7, 7, 7, 7, 80, 40000.00, 69000.00, '12 tháng', 'lipbalm.jpg', 'Dưỡng ẩm và thơm nhẹ'),
(8, 'Tẩy trang mắt môi', 8, 8, 8, 8, 8, 8, 8, 8, 65, 65000.00, 105000.00, '12 tháng', 'remover.jpg', 'Tẩy sạch nhẹ dịu'),
(9, 'Serum dưỡng trắng', 9, 9, 9, 9, 9, 9, 9, 9, 30, 150000.00, 250000.00, '12 tháng', 'serum.jpg', 'Dưỡng sáng da hiệu quả'),
(10, 'Mặt nạ đất sét', 10, 10, 10, 10, 10, 10, 10, 10, 45, 85000.00, 149000.00, '6 tháng', 'mask.jpg', 'Làm sạch sâu lỗ chân lông');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `productusage`
--

CREATE TABLE `productusage` (
  `UsageID` int(11) NOT NULL,
  `UsageName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `productusage`
--

INSERT INTO `productusage` (`UsageID`, `UsageName`) VALUES
(1, 'Dưỡng ẩm'),
(2, 'Làm sạch'),
(3, 'Chống nắng'),
(4, 'Trang điểm'),
(5, 'Trị mụn'),
(6, 'Tái tạo da'),
(7, 'Làm trắng'),
(8, 'Chống lão hóa'),
(9, 'Se khít lỗ chân lông'),
(10, 'Dưỡng môi');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `saleinvoice`
--

CREATE TABLE `saleinvoice` (
  `SaleInvoiceID` int(11) NOT NULL,
  `EmployeeID` int(11) DEFAULT NULL,
  `SaleDate` date DEFAULT NULL,
  `CustomerID` int(11) DEFAULT NULL,
  `TotalAmount` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `saleinvoice`
--

INSERT INTO `saleinvoice` (`SaleInvoiceID`, `EmployeeID`, `SaleDate`, `CustomerID`, `TotalAmount`) VALUES
(1, 1, '2024-04-11', 1, 180000.00),
(2, 2, '2024-04-12', 2, 240000.00),
(3, 3, '2024-04-13', 3, 100000.00),
(4, 4, '2024-04-14', 4, 160000.00),
(5, 5, '2024-04-15', 5, 300000.00),
(6, 1, '2024-04-16', 2, 120000.00),
(7, 2, '2024-04-17', 3, 220000.00),
(8, 3, '2024-04-18', 4, 170000.00),
(9, 4, '2024-04-19', 5, 260000.00),
(10, 5, '2024-04-20', 1, 190000.00);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `saleinvoicedetail`
--

CREATE TABLE `saleinvoicedetail` (
  `SaleInvoiceID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Discount` decimal(5,2) DEFAULT NULL,
  `Total` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `saleinvoicedetail`
--

INSERT INTO `saleinvoicedetail` (`SaleInvoiceID`, `ProductID`, `Quantity`, `Discount`, `Total`) VALUES
(1, 1, 2, 0.00, 180000.00),
(2, 2, 3, 0.10, 240000.00),
(3, 3, 1, 0.00, 100000.00),
(4, 4, 2, 0.05, 160000.00),
(5, 5, 4, 0.00, 300000.00),
(6, 6, 1, 0.00, 120000.00),
(7, 7, 2, 0.05, 220000.00),
(8, 8, 3, 0.00, 170000.00),
(9, 9, 2, 0.10, 260000.00),
(10, 10, 1, 0.00, 190000.00);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `season`
--

CREATE TABLE `season` (
  `SeasonID` int(11) NOT NULL,
  `SeasonName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `season`
--

INSERT INTO `season` (`SeasonID`, `SeasonName`) VALUES
(1, 'Xuân'),
(2, 'Hè'),
(3, 'Thu'),
(4, 'Đông'),
(5, 'Mọi mùa'),
(6, 'Mùa mưa'),
(7, 'Mùa khô'),
(8, 'Lạnh'),
(9, 'Nắng'),
(10, 'Ẩm');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(100) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`, `Address`, `Phone`) VALUES
(1, 'Công ty A', 'Hà Nội', '0922222221'),
(2, 'Công ty B', 'Hồ Chí Minh', '0922222222'),
(3, 'Công ty C', 'Đà Nẵng', '0922222223'),
(4, 'Công ty D', 'Hải Phòng', '0922222224'),
(5, 'Công ty E', 'Huế', '0922222225'),
(6, 'Công ty F', 'Cần Thơ', '0922222226'),
(7, 'Công ty G', 'Nha Trang', '0922222227'),
(8, 'Công ty H', 'Vũng Tàu', '0922222228'),
(9, 'Công ty I', 'Biên Hòa', '0922222229'),
(10, 'Công ty J', 'Quảng Nam', '0922222230');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `type`
--

CREATE TABLE `type` (
  `TypeID` int(11) NOT NULL,
  `TypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `type`
--

INSERT INTO `type` (`TypeID`, `TypeName`) VALUES
(1, 'Nước hoa'),
(2, 'Son môi'),
(3, 'Sữa rửa mặt'),
(4, 'Kem dưỡng'),
(5, 'Phấn phủ'),
(6, 'Tẩy trang'),
(7, 'Kem chống nắng'),
(8, 'Serum'),
(9, 'Toner'),
(10, 'Mặt nạ');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `unit`
--

CREATE TABLE `unit` (
  `UnitID` int(11) NOT NULL,
  `UnitName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `unit`
--

INSERT INTO `unit` (`UnitID`, `UnitName`) VALUES
(1, '2g'),
(2, '5g'),
(3, '10g'),
(4, '50g'),
(5, '100ml'),
(6, '250ml'),
(7, '500ml'),
(8, '1kg'),
(9, '5ml'),
(10, '75ml');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `color`
--
ALTER TABLE `color`
  ADD PRIMARY KEY (`ColorID`);

--
-- Chỉ mục cho bảng `country`
--
ALTER TABLE `country`
  ADD PRIMARY KEY (`CountryID`);

--
-- Chỉ mục cho bảng `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Chỉ mục cho bảng `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeID`),
  ADD KEY `JobID` (`JobID`);

--
-- Chỉ mục cho bảng `importinvoice`
--
ALTER TABLE `importinvoice`
  ADD PRIMARY KEY (`ImportInvoiceID`),
  ADD KEY `EmployeeID` (`EmployeeID`),
  ADD KEY `SupplierID` (`SupplierID`);

--
-- Chỉ mục cho bảng `importinvoicedetail`
--
ALTER TABLE `importinvoicedetail`
  ADD PRIMARY KEY (`ImportInvoiceID`,`ProductID`),
  ADD KEY `ProductID` (`ProductID`);

--
-- Chỉ mục cho bảng `job`
--
ALTER TABLE `job`
  ADD PRIMARY KEY (`JobID`);

--
-- Chỉ mục cho bảng `manufacturer`
--
ALTER TABLE `manufacturer`
  ADD PRIMARY KEY (`ManufacturerID`);

--
-- Chỉ mục cho bảng `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`MaterialID`);

--
-- Chỉ mục cho bảng `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`),
  ADD KEY `TypeID` (`TypeID`),
  ADD KEY `UnitID` (`UnitID`),
  ADD KEY `ManufacturerID` (`ManufacturerID`),
  ADD KEY `MaterialID` (`MaterialID`),
  ADD KEY `UsageID` (`UsageID`),
  ADD KEY `SeasonID` (`SeasonID`),
  ADD KEY `ColorID` (`ColorID`),
  ADD KEY `CountryID` (`CountryID`);

--
-- Chỉ mục cho bảng `productusage`
--
ALTER TABLE `productusage`
  ADD PRIMARY KEY (`UsageID`);

--
-- Chỉ mục cho bảng `saleinvoice`
--
ALTER TABLE `saleinvoice`
  ADD PRIMARY KEY (`SaleInvoiceID`),
  ADD KEY `EmployeeID` (`EmployeeID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- Chỉ mục cho bảng `saleinvoicedetail`
--
ALTER TABLE `saleinvoicedetail`
  ADD PRIMARY KEY (`SaleInvoiceID`,`ProductID`),
  ADD KEY `ProductID` (`ProductID`);

--
-- Chỉ mục cho bảng `season`
--
ALTER TABLE `season`
  ADD PRIMARY KEY (`SeasonID`);

--
-- Chỉ mục cho bảng `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- Chỉ mục cho bảng `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`TypeID`);

--
-- Chỉ mục cho bảng `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`UnitID`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `color`
--
ALTER TABLE `color`
  MODIFY `ColorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `country`
--
ALTER TABLE `country`
  MODIFY `CountryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `employee`
--
ALTER TABLE `employee`
  MODIFY `EmployeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `importinvoice`
--
ALTER TABLE `importinvoice`
  MODIFY `ImportInvoiceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `job`
--
ALTER TABLE `job`
  MODIFY `JobID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `manufacturer`
--
ALTER TABLE `manufacturer`
  MODIFY `ManufacturerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `material`
--
ALTER TABLE `material`
  MODIFY `MaterialID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `product`
--
ALTER TABLE `product`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `productusage`
--
ALTER TABLE `productusage`
  MODIFY `UsageID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `saleinvoice`
--
ALTER TABLE `saleinvoice`
  MODIFY `SaleInvoiceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `season`
--
ALTER TABLE `season`
  MODIFY `SeasonID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `type`
--
ALTER TABLE `type`
  MODIFY `TypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `unit`
--
ALTER TABLE `unit`
  MODIFY `UnitID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`JobID`) REFERENCES `job` (`JobID`);

--
-- Các ràng buộc cho bảng `importinvoice`
--
ALTER TABLE `importinvoice`
  ADD CONSTRAINT `importinvoice_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`),
  ADD CONSTRAINT `importinvoice_ibfk_2` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- Các ràng buộc cho bảng `importinvoicedetail`
--
ALTER TABLE `importinvoicedetail`
  ADD CONSTRAINT `importinvoicedetail_ibfk_1` FOREIGN KEY (`ImportInvoiceID`) REFERENCES `importinvoice` (`ImportInvoiceID`),
  ADD CONSTRAINT `importinvoicedetail_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

--
-- Các ràng buộc cho bảng `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`TypeID`) REFERENCES `type` (`TypeID`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`UnitID`) REFERENCES `unit` (`UnitID`),
  ADD CONSTRAINT `product_ibfk_3` FOREIGN KEY (`ManufacturerID`) REFERENCES `manufacturer` (`ManufacturerID`),
  ADD CONSTRAINT `product_ibfk_4` FOREIGN KEY (`MaterialID`) REFERENCES `material` (`MaterialID`),
  ADD CONSTRAINT `product_ibfk_5` FOREIGN KEY (`UsageID`) REFERENCES `productusage` (`UsageID`),
  ADD CONSTRAINT `product_ibfk_6` FOREIGN KEY (`SeasonID`) REFERENCES `season` (`SeasonID`),
  ADD CONSTRAINT `product_ibfk_7` FOREIGN KEY (`ColorID`) REFERENCES `color` (`ColorID`),
  ADD CONSTRAINT `product_ibfk_8` FOREIGN KEY (`CountryID`) REFERENCES `country` (`CountryID`);

--
-- Các ràng buộc cho bảng `saleinvoice`
--
ALTER TABLE `saleinvoice`
  ADD CONSTRAINT `saleinvoice_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`),
  ADD CONSTRAINT `saleinvoice_ibfk_2` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- Các ràng buộc cho bảng `saleinvoicedetail`
--
ALTER TABLE `saleinvoicedetail`
  ADD CONSTRAINT `saleinvoicedetail_ibfk_1` FOREIGN KEY (`SaleInvoiceID`) REFERENCES `saleinvoice` (`SaleInvoiceID`),
  ADD CONSTRAINT `saleinvoicedetail_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
