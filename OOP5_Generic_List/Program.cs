/*
 Sử dụng generic list để quản lý nhân sự với đầy đủ
Tính năng CRUD
C - CREATE ---> Tạo mới dữ liệu
R - Read/Retrieve -> Xem, lọc, tìm kiếm, sắp xếp. thống kê,....
U - Update --> sữ dữ liệu
D - Delete --> Xóa dữ liệu
 */
//câu 1: Tạo 5 nhân viên, 3 nhân viên chính thức và 2 nhân viên thời vụ
//lưu vào generic 
        using OOP2;

        using System.Text;

    Console.OutputEncoding = Encoding.UTF8;
        List<Employee> employees = new List<Employee>();
        FulltimeEmployee fe1 = new FulltimeEmployee()
        {
            Id = 1,
            IdCard = "123",
            Name = "Name 1",
            Birthday = new DateTime(1990, 12, 27)
        };
        employees.Add(fe1);
        FulltimeEmployee fe2 = new FulltimeEmployee()
        {
            Id = 2,
            IdCard = "456",
            Name = "Name 2",
            Birthday = new DateTime(2000, 7, 15)
        };
        employees.Add(fe2);

        FulltimeEmployee fe3 = new FulltimeEmployee()
        {
            Id = 3,
            IdCard = "678",
            Name = "Name 3",
            Birthday = new DateTime(2004, 10, 8)
        };
        employees.Add(fe3);

        ParttimeEmployee pe1 = new ParttimeEmployee()
        {
            Id = 4,
            IdCard = "246",
            Name = "Name 4",
            Birthday = new DateTime(2004, 9, 8),
            WorkingHour = 5
        };
        employees.Add(pe1);
        ParttimeEmployee pe2 = new ParttimeEmployee()
        {
            Id = 5,
            IdCard = "468",
            Name = "Name 5",
            Birthday = new DateTime(2004, 1, 31),
            WorkingHour = 3
        };
        employees.Add(pe2);

        //Câu 2: R- Xuất toàn bộ nhân sự 
        Console.WriteLine("Câu 2: R -> Information of employee: ");
        //Cách 1: 
        employees.ForEach(e => Console.WriteLine(e));


        //Câu 3: Lọc ra các nhân sự là chính thức 
        //Cách 1: 
        List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
        Console.WriteLine("Câu 3: Loc nhan vien chinh thuc: ");
        foreach (FulltimeEmployee fe in fe_list)
        {
            Console.WriteLine(fe);
        }

        //Câu 4: Tính tổng tiền lương trả cho nhân viên  chính thức 
        double fe_sum_salary = fe_list.Sum(e => e.calSalary());
        Console.WriteLine("Câu 4: Tong luong nhan vien chinh thuc: ");
        Console.WriteLine(fe_sum_salary);

        //Câu 5: Tính tổng tiền lương trả cho nhân viên  thời vụ
        double pe_sum_salary = employees.OfType<ParttimeEmployee>().Sum(e => e.calSalary());
        Console.WriteLine("Câu 5: Tong luong nhan vien thoi vu: ");
        Console.WriteLine(pe_sum_salary);


        // Câu 6: Update employee information 
        Console.WriteLine("\nCâu 6: Update employee information:");
        Console.Write("Input employee's Id that you wanna update: ");
        int Id = int.Parse(Console.ReadLine());
        Employee empToUpdate = employees.FirstOrDefault(e => e.Id == Id);

        if (empToUpdate != null)
        {
        // Update thông tin
            Console.Write("Input new Name: ");
            string Name = Console.ReadLine();
            if(Name.Trim().Length != 0) {
                empToUpdate.Name = Name;
            }

            Console.Write("Input new IdCard: ");
            string IdCard = Console.ReadLine();
            if (Name.Trim().Length != 0)
            {
                empToUpdate.IdCard = IdCard;
            }

            Console.Write("Nhập ngày sinh (ví dụ: 20/05/1985): ");
            DateTime empBirthday = DateTime.Parse(Console.ReadLine());
            empToUpdate.Birthday = empBirthday;

            Console.WriteLine("Sau khi update:");
            Console.WriteLine(empToUpdate);
        }

        // Câu 7: Delete employee
        Console.WriteLine("\nCâu 7: Delete employee information:");
        Console.Write("Input employee's Id that you wanna Delete: ");
        int IdDelete = int.Parse(Console.ReadLine());

        Employee empToDelete = employees.FirstOrDefault(e => e.Id == IdDelete);
        if (empToDelete != null)
        {
           employees.Remove(empToDelete);
        }

        // Hiển thị danh sách nhân viên sau khi xóa
        Console.WriteLine("\nDanh sách nhân viên sau khi xóa:");
        employees.ForEach(e => Console.WriteLine(e));


