```
<list>
namespace ListExam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr =new List<int>();
            for(int i =0; i<100; i++)
            {
                arr.Add(i+1);
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```
```
<퀴즈 1 교집합 구하기>
  static void Main(string[] args)

        {
            List<int> list1 = new List<int>() {1, 2, 2, 3, 4 };
            List<int> list2 = new List<int>() {2, 3, 5, 6 };
            List<int> list3 = new List<int>();
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j] && !(list3.Contains(list1[i])))
                    {
                        list3.Add(list2[j]);
                        Console.WriteLine(list2[j]);
                        break;
                    }
                }
            }
        }
    }
}

```
```
<퀴즈문제 file>
namespace FileExam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\abc.txt";
            FileInfo fi = new FileInfo(path);
            using (StreamWriter sw = fi.CreateText())
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 5 == 0)
                        sw.Write(i + " ");
                }
            }

            using (StreamReader sr = fi.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
```
```
<복사하기>
namespace FileExam_newjeans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\a001.png";
            string copyPic = @"C:\Temp\a002.png";
            try
            {
                byte[] pictureBytes = File.ReadAllBytes(path);
                File.WriteAllBytes(copyPic, pictureBytes);
                Console.WriteLine("복사 성공");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
```
```
namespace fileExam05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\a001.log";
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine("정처기 가즈아");
                    sw.WriteLine("Anderson");
                    sw.WriteLine(32000);
                }
            }
        }
    }
}
```
```
namespace FileExam05_Basic10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;

            Console.WriteLine($"{someValue : X16}");
            string path = @"C:\Temp\a.dat";
            Stream outStream = new FileStream(path, FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);

            //화면에 byte 출력
            foreach (byte b in wBytes)
            {
                Console.WriteLine($"{b:X16}");
            }
            Console.WriteLine();
            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();
            //읽기 -> binary -> text 화면출력
            Stream inStream = new FileStream(path, FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length) {
                rbytes[i++] = (byte)inStream.ReadByte();
                }
            Console.WriteLine();
            long readValue = BitConverter.ToInt64(rbytes, 0);
            Console.WriteLine($"{readValue : X16}");
            }
        }
    }
```
```
namespace ThreadTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start();
            t.Join();
            string mtName = Thread.CurrentThread.Name;
            Console.WriteLine($"{mtName} 프로그램 종료");
        }
           static void threadFunc()
           {
            Console.WriteLine("7초 후에 프로그램 종료");
            Thread.Sleep(7000);

            Thread.CurrentThread.Name = "개발부장";
            string mtName = Thread.CurrentThread.Name;
            Console.WriteLine($"{mtName} 프로그램 종료");
      
           }
    }
}
```
```
