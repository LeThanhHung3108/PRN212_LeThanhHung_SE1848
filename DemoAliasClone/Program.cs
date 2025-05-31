using DemoAliasClone;


Customer c1  = new Customer();
c1.Id = 1;
c1.Name = "hung";
Customer c2 = new Customer();
c2.Id = 2;
c2.Name = "thanhhung";

c1 = c2;
//c1 trỏ tới vùng nhớ mà c2 đang quản lý 
//chứ ko phải c1 bằng c2
//=> lúc này xảy ra 2 tình huống
//(1) Ô nhớ alpha mà c1 quản lý lúc nãy bị trống, ko còn đối tượng nào tham gia quản lý nữa 
//=> Hệ điều hành sẽ thu hồi ô nhớ alpha này
// gọi là cơ chế gom rác tự động: Automatic Garbage collection
//Ta ko thể nào lấy được giá trị tại ô nhớ này nữa 
//(2) Lúc này ô nhớ Beta sẽ có 2 đối tượng tham gia quản lý 
// - đối tượng ban đầu là c2
//- bây giwof có thêm đối tượng c1 quản lý
//Trường hợp 1 ô nhớ từ 2 đối tuwowngjk trở lên tham gia quản lý
//nó đc gọi là alias 
// --> Bất kỳ 1 đối tựơng nào đổi giá trị tại ô nhớ Beta
// --> thì các đối tượng còn lại đều ảnh hưởng 

c1.Name = "Lethanhhung";
//Thì lúc này c2 cũng bị đổi tên thành Lethanhhung
//vì c1 và c2 đnag quản lý 1 ô nhớ
Console.WriteLine("Tên của c2 = " + c2.Name);

Customer c3 = new Customer();
Customer c4 = c3;
         c3 = c1;
//Không có thu hồi ô nhớ của c3 đang quản lý oqr dòng c3