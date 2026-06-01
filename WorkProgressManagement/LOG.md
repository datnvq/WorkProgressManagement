# LOG - Hệ thống quản lý và theo dõi tiến độ công việc

## Thông tin dự án
- Tên dự án: WorkProgressManagement
- Công nghệ: WPF + .NET + Entity Framework Core
- IDE: Visual Studio
- Database: SQLite

---

# Quy tắc làm việc

1. Trước mỗi bước phải đọc LOG.md.
2. Sau mỗi bước phải cập nhật LOG.md.
3. Ghi rõ file đã tạo/sửa.
4. Nếu có lỗi phải ghi lại nguyên nhân và cách sửa.
5. Chia task thành bước nhỏ để dễ kiểm soát.

---

# Tiến độ

## Bước 1 - Khởi tạo project
Trạng thái: Hoàn thành

Đã làm:
- Tạo project WPF .NET.
- Khởi tạo Git.
- Push GitHub.

File liên quan:
- App.xaml
- MainWindow.xaml
- .gitignore

---

## Bước 2 - Tạo LOG quản lý tiến độ
Trạng thái: Đang thực hiện

Cần làm:
- Tạo file LOG.md
- Thiết lập quy tắc làm việc

File liên quan:
- LOG.md

## Bước 3 - Tạo cấu trúc thư mục
Trạng thái: Hoàn thành

Đã làm:
- Tạo folder Data
- Tạo folder Models
- Tạo folder Services
- Tạo folder Views
- Tạo folder ViewModels
- Tạo folder Resources

## Bước 4 - Cài Entity Framework 6 cho WPF .NET Framework

Trạng thái: Hoàn thành

Đã làm:
- Không dùng Entity Framework Core vì project là WPF App (.NET Framework).
- Cài EntityFramework 6.5.1.
- Cài System.Data.SQLite.
- Cài System.Data.SQLite.EF6.

Lý do:
- Project đang dùng .NET Framework 4.8.
- EF Core version mới không tương thích với .NET Framework 4.8.
- Entity Framework 6 phù hợp hơn với WPF .NET Framework.

## Bước 5 - Tạo model Project

Trạng thái: Hoàn thành

Đã làm:
- Tạo file Models/Project.cs
- Khai báo model Project
- Thiết lập quan hệ một-nhiều với WorkTask

File liên quan:
- Models/Project.cs

## Bước 6 - Tạo model WorkTask

Trạng thái: Hoàn thành

Đã làm:
- Tạo file Models/WorkTask.cs
- Thiết lập khóa ngoại ProjectId
- Thiết lập quan hệ với Project

File liên quan:
- Models/WorkTask.cs

## Bước 7 - Tạo AppDbContext

Trạng thái: Hoàn thành

Đã làm:
- Tạo file Data/AppDbContext.cs
- Khai báo DbSet Projects
- Khai báo DbSet WorkTasks
- Chuẩn bị kết nối database bằng tên WorkProgressDb

File liên quan:
- Data/AppDbContext.cs