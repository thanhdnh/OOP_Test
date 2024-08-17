using System.Collections;
using System.Runtime.CompilerServices;
//https://github.com/thanhdnh/OOP_Test
public class Program
{
    /* Giả một mặt hàng có: tên hàng, khối lượng, đơn giá
    a) Khai báo lớp hàng hoá
    b) Tạo 1 mảng 5 hàng hoá (giá trị ngẫu nhiên)
    c) In thông tin thông tin các mặt hàng
    d) Tính tổng tiền hàng
    */
    /*static HangHoa[] hang = new HangHoa[5];
    public static void NhapHang(){
        for(int i=0; i<5; i++){
            hang[i] = new HangHoa();
            hang[i].tenhang = "Hang "+i;
            hang[i].soluong = new Random().Next(5, 15);
            hang[i].dongia = (float)Math.Round(
                new Random().NextSingle()*15000);
        }
    }
    public static float beautify(float num){
        return (float)(1000*Math.Floor(num/1000));
    }
    public static void ShowInfo(){
        Console.WriteLine("{0, 5}|{1, 10}|{2, 10}|{3, 10}", 
        "STT", "Ten hang", "So luong", "Don gia");
        for(int i=0; i<hang.Length; i++){
            Console.WriteLine("{0, 5}|{1, 10}|{2, 10}|{3, 10}", 
            i, hang[i].tenhang, hang[i].soluong, 
            beautify(hang[i].dongia));
        }
    }
    public static float TongGia(){
        float sum = 0;
        for(int i=0; i<hang.Length; i++)
            sum += hang[i].soluong*hang[i].dongia;
        return sum;
    }
    */
    /*
        Một lớp Book{id, tên_sách, tác_giả, số_lượng}
        a) Xây dựng lớp Book
        b) Tạo một List gồm 5 cuốn sách
        c) Thêm hàm tìm kiếm theo tên sách hoặc tên tác giả
        d) Kiểm tra tình trạng còn sách trong thư viện 
    */
    static List<Book> books = new List<Book>();

    public static void init()
    {
        Random rnd = new Random();
        for (int i = 1; i <= 5; i++)
        {
            Book a_book = new Book();
            a_book.id = i;
            a_book.ten_sach = "Book " + i;
            a_book.ten_tg = "tac gia " + i;
            a_book.so_luong = rnd.Next(0, 10);
            books.Add(a_book);
        }
    }
    public static List<Book> search(string kw)
    {
        List<Book> result = new List<Book>();
        for (int i = 0; i < books.Count; i++)
            if (books[i].ten_sach.IndexOf(kw) >= 0 ||
                            books[i].ten_tg.IndexOf(kw) >= 0)
                result.Add(books[i]);
        return result;
    }
    public static bool check(int id){
        foreach (Book b in books){
            if (b.id == id){
                if (b.so_luong > 0)
                    return true;
                else
                    return false;
            }
        }
        return false;
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        //NhapHang();
        //ShowInfo();
        /*init();
        List<Book> res = search("4");
        foreach(Book b in res)
            Console.WriteLine(b.id + ", " + b.ten_sach 
                    + ", " + b.ten_tg + ", " + b.so_luong);
        Console.WriteLine("Tinh trang sach co id = 4: " 
        
                                            + check(4));
    */
        //Employee emp = new Employee();
        //Employee emp = new Employee("Hoa", 210f);
        //Employee emp2 = new Employee(emp);//emp;
        //emp2.Name = "Nam";
        //Employee em = new Employee();
        //emp.Name = "Nam";
        //emp.Salary = 200f;
        //Console.WriteLine(emp.Name+", "+emp.Salary);
        //Console.WriteLine(emp2.Name+", "+emp2.Salary);
        //Default, 0
        //Candidate cand = new Candidate("Nam", 100f, true);
        //Console.WriteLine(cand.ShowInfo());
        Candidate[] candidates = new Candidate[5];
        candidates[0] = new Candidate("Nam", 98f, true);
        candidates[1] = new Candidate("Hoa", 99f, false);
        candidates[2] = new Candidate("Binh", 91f, true);
        candidates[3] = new Candidate("Lan", 99.5f, false);
        candidates[4] = new Candidate("Tuan", 91f, true);

        /*foreach(Candidate c in candidates)
            Console.WriteLine(c.ShowInfo());*/
        ListOfCandidates list = new ListOfCandidates(candidates);
        ArrayList result = list.search("an");
        foreach(Candidate c in result)
            Console.WriteLine(c.ShowInfo());

        Console.ReadKey();
    }
}