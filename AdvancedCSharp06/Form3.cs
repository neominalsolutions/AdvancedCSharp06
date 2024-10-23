using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCSharp06
{
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
    }

    // TPL (Task Parelel Library)
    // Thread den daha performanslı thread yapısı üzerine inşaa edilmiş bir kütüphane yaratıldı.
    // NET 4.0 ve sonrasında kütüphaneye katıldı.
    // Thread İşletim sistemi çalışırken
    // Task ise daha soyut bir yapı temsil ederek. Programlama seviyesine çalışmak için oluşturuldu.
    // Task değer döndürebilirken, Thread bunu yapamaz.
    // Thread açtığımız anda işletim sistemi seviyesinde bir iş parçacığı oluşurken
    // Task ile Thread Pool bir mekanizma içerisinde paralel görevler açılarak paralel yönetilir. Hangi thread'e atanacağına program karar verir.
    // Programcının daha falza uygulamada beceri kazandırmasını sağlayan bir yapıya sahiptir. Eğer asenkron olan işlemin bitmesi ve sonucun alınması gerekirse async await keyword ile yapılabilir.
    // Thread de async await yapısı bulunmaz.
    // Task TaskQuee dediğimiz bir koleksiyon içerisinde barındırılır. 
    // Thread bir işlemicinin tek çekirdeiğini kullanırken, Task ise işlemin çekirdek sayısı kadar farklı işlem parçacıklarına bölünür. Performası sağlar.
    // Thread Sleep uygulamın Main thread'inde çalışarak alt işlemleri kitlerken Task.Delay kodu diğer işlemleri bloke etmez.

    private void Form3_Load(object sender, EventArgs e)
    {
     

    }

    private async void btnFill_Click(object sender, EventArgs e)
    {
      // çapraz thread çağırısı için bu özelliği windows form ortamında açtık
      Control.CheckForIllegalCrossThreadCalls = false;

      // ayrı bir iş parçacığı açtık
      Task t1 = new Task(ListBox1Doldur);
       t1.Start(); // thread başlattık

      Task t2 = new Task(ListBox2Doldur);
      t2.Start();

      Task t3 = new Task(ListBox3Doldur);
      t3.Start();

      //  task-based asynchronous pattern (TAP)

     await Task.WhenAll(t1, t2, t3); 


      //string response = await GetValue(); // Thread response üzerinde işlem yapma gibi bir yetenek maalesef yok

      // await GetVoid();
    }

    private async void ListBox1Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
         Task.Delay(1000); // 1 saniye de bir girilsin
        // sıralı bir veri tabanı işlemi söz konusu ise bu durumda await yapısı ile kodu bekletip result alıp yola devam edebiliriz
        listBox1.Items.Add($"{i}, threadId: {Thread.CurrentThread.ManagedThreadId}" );
        
      }
    }

    private async void ListBox2Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
         Task.Delay(1000); // 1000 ms 1 saniye de bir girilsin
        listBox2.Items.Add($"{i}, threadId: {Thread.CurrentThread.ManagedThreadId}");
      }
    }

    private async void ListBox3Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
         Task.Delay(1000); // 1 saniye de bir girilsin
        listBox3.Items.Add($"{i}, threadId: {Thread.CurrentThread.ManagedThreadId}");
      }
    }

    // değer döndüren async method tanımı
    public async Task<string> GetValue()
    {
      await Task.Run(ListBox1Doldur);

     

      return await Task.FromResult<string>("Bitti");

    }

    // değer döndürmeyen async method tanımı
    public async Task GetVoid()
    {
      await Task.Run(ListBox2Doldur);
    }


  }
}
