Public Class Form2

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Programı kullandıgınız zaman Lisans sözleşmesini kabul etmis sayılırsınız")
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        RichTextBox1.Text += " Coded By Furkan"
        RichTextBox1.Text += "  furkanfbr@gmail.com"
        RichTextBox1.Text += "GNU Genel Kamu Lisansı (GPL)"
        RichTextBox1.Text += "Sürüm 1, Subat 2013"

        RichTextBox1.Text += "Telif Hakkı (C) 1989, 1991 Free Software Foundation, Inc. 59 Temple Place - Suite 330, Boston, MA 02111-1307, "
        RichTextBox1.Text += "USA()"
        RichTextBox1.Text += "Bu lisans dökümanının birebir kopyalarını yapma ve dağıtma izni herkese verilmiştir, fakat metinde değişiklik yapma "
        RichTextBox1.Text += "        izni()"
        RichTextBox1.Text += "yoktur."

        RichTextBox1.Text += "       GİRİŞ()"

        RichTextBox1.Text += "Yazılım lisanslarının çoğu sizin yazılımı paylaşma ve değiştirme hakkınızın elinizden alınması için hazırlanmıştır. Buna "
        RichTextBox1.Text += "karşılık, GNU Genel Kamu Lisansı sizin serbest yazılımları değiştirme ve paylaşma hakkınızın mahfuz tutulması ve "
        RichTextBox1.Text += "yazılımın bütün kullanıcıları için serbest olması amacı ile yazılmıştır. Bu Genel Kamu Lisansı, Free Software "
        RichTextBox1.Text += "Foundation() 'un çoğu yazılımı ve bu lisansı kullanmayı düstur edinen diğer yazılımcıların yazılımları için kullanılmaktadır. "
        RichTextBox1.Text += "(Free Software Foundation'un bazı yazılımları GNU Kitaplık Genel Kamu Lisansı -- GNU LGPL -- altında dağıtılmaktadır.) "
        RichTextBox1.Text += "Siz de bu lisansı yazılımlarınıza uygulayabilirsiniz. "
        RichTextBox1.Text += ""
        RichTextBox1.Text += "Serbest yazılımdan bahsettiğimiz zaman fiyattan değil, özgürlükten bahsediyoruz. Bizim Genel Kamu Lisanslarımız, "
        RichTextBox1.Text += "  sizin()"
        RichTextBox1.Text += "serbest yazılımların kopyalarını dağıtma özgürlüğünüzü (ve isterseniz bu hizmet için para almanızı), yazılım kaynak "
        RichTextBox1.Text += "kodlarının size dağıtım esnasında veya eğer isterseniz verilmesini, yazılımı değiştirebilmenizi, yazılımın parçalarını "
        RichTextBox1.Text += "  yeni()"
        RichTextBox1.Text += "yazılımlar içerisinde kullanabilmenizi ve bunları yapabileceğinizi bilmenizi sağlamaktadır. "
        RichTextBox1.Text += ""
        RichTextBox1.Text += "Haklarınızı koruyabilmemiz için sizin haklarınızı kısıtlama veya sizin bu haklarınızdan feragat etmenizi isteme "
        RichTextBox1.Text += "  yollarını()"
        RichTextBox1.Text += "yasaklayıcı bazı kısıtlamalar getirmemiz gerekmektedir. Bu kısıtlamalar eğer serbest yazılım dağıtıyor veya "
        RichTextBox1.Text += "değiştiriyorsanız size bazı yükümlülükler getirmektedir. "
        RichTextBox1.Text += ""
        RichTextBox1.Text += "Örneğin böyle bir programın kopyalarını, bedava veya ücret karşılığı dağıtıyorsanız alıcılara sizin sahip olduğunuz "
        RichTextBox1.Text += "       bütün()"
        RichTextBox1.Text += "hakları sağlamalısınız. Onların da kaynak kodlarına sahip olmalarını veya ulaşabilmelerini sağlamalısınız. Onlara da "
        RichTextBox1.Text += "haklarını bilebilmeleri için bu şartları göstermelisiniz. "
        RichTextBox1.Text += ""
        RichTextBox1.Text += "Haklarınızı iki koruma iki aşamada gerçekleşmektedir: (1) Yazılıma telif hakkı alınmaktadır. (2) Yazılım lisansı olarak "
        RichTextBox1.Text += "size, "
        RichTextBox1.Text += "hukuki olarak, yazılımı kopyalama, dağıtma ve/veya değiştirme hakkı tanıyan bu lisans sunulmaktadır. "

        RichTextBox1.Text += "Ayrıca, yazarların ve bizim korunmamız için bu serbest yazılımın herhangi bir garantisi olmadığını herkesin anlamasını "
        RichTextBox1.Text += "istiyoruz. Eğer yazılım başkası tarafından değiştirilmiş ve değiştirilmiş hali ile tarafınıza ulaştırılmış ise alıcıların, "
        RichTextBox1.Text += "ellerinde()"
        RichTextBox1.Text += "olan yazılımın orjinal olmadığını, dolayısıyla başkaları tarafından eklenen problemlerin ilk yazarların şöhretlerine "
        RichTextBox1.Text += "       olumsuz()"
        RichTextBox1.Text += "etkide bulunmaması gerektiğini bilmelerini istiyoruz. "

        RichTextBox1.Text += "Son olarak, bütün serbest yazılımlar yazılım patentleri tarafından sürekli tehdit altında bulunmaktadır. Serbest bir "
        RichTextBox1.Text += "        yazılımın()"
        RichTextBox1.Text += "dağıtıcılarının bireysel olarak patent lisansı almalarını ve bu yol ile yazılımı müseccel hale getirmelerine imkan "
        RichTextBox1.Text += "        vermemek()"
        RichTextBox1.Text += "istiyoruz. Bunu engellemek için, yazılım için alınacak her patentin herkesin serbest kullanımına izin vermesi veya "
        RichTextBox1.Text += "patentlenmemesi gerektiğini açık olarak ortaya koyuyoruz. "

        RichTextBox1.Text += "Kopyalama, dağıtım ve değiştirme ile ilgili kesin şart ve kayıtlar aşağıda yer almaktadır. "

        RichTextBox1.Text += "KOPYALAMA, DAĞITIM VE DEĞİŞTİRME İLE İLGİLİ ŞART VE KAYITLAR "

        RichTextBox1.Text += "0. Bu Lisans, telif hakkı sahibi tarafından içerisine bu Genel Kamu Lisansı altında dağıtıldığına dair ibare konmuş olan "
        RichTextBox1.Text += "herhangi bir yazılım veya başka eseri kapsamaktadır. Aşağıda Yazılım, bu kapsamdaki herhangi bir yazılım veya "
        RichTextBox1.Text += "eser, "
        RichTextBox1.Text += "Yazılımı baz alan ürün, ise Yazılım veya telif kanunu altında Yazılım'dan iştikak etmiş, yani Yazılım'ın tamamını veya  "
        RichTextBox1.Text += "        bir()"
        RichTextBox1.Text += "parçasını, değiştirmeden veya değişiklikler ile, veya başka bir dile tercüme edilmiş hali ile içeren herhangi bir ürün, "
        RichTextBox1.Text += "manasında kullanılmaktadır. (Bundan sonra tercüme değiştirme kapsamında sınırsız olarak içerilecektir.) Her ruhsat "
        RichTextBox1.Text += "sahibine siz olarak hitap edilmektedir. "

        RichTextBox1.Text += "Kopyalama, dağıtım ve değiştirme haricinde kalan faaliyetler bu Lisans'ın kapsamı dışındadırlar. Yazılım'ı çalıştırma "
        RichTextBox1.Text += "        eylemi()"
        RichTextBox1.Text += "sınırlandırılmamıştır ve Yazılım'ın çıktısı yalnızca çıktının içeriği (Yazılım'ı çalıştırmak yolu ile elde edilmesinden "
        RichTextBox1.Text += "        bağımsız()"
        RichTextBox1.Text += "olarak) Yazılım'ı baz alan ürün kapsamına girer ise bu Lisans kapsamındadır. Bu koşulun sağlanıp sağlanmadığı "
        RichTextBox1.Text += "     Yazılım() 'ın ne yaptığı ile ilgilidir. "

        RichTextBox1.Text += "1:      .Yazılım() 'ın kaynak kodlarını birebir, aldığınız şekilde, herhangi bir ortamda ve vasıta ile, uygun ve görünür bir "
        RichTextBox1.Text += "        şekilde()"
        RichTextBox1.Text += "telif hakkı bildirimi ve garantisiz olduğuna dair bildirim koymak, bu Lisans'dan bahseden herhangi bir bildirimi aynen "
        RichTextBox1.Text += "muhafaza etmek ve bütün diğer alıcılara Yazılım ile birlikte bu Lisans'ın bir kopyasını vermek şartı ile kopyalayabilir "
        RichTextBox1.Text += "       ve()"
        RichTextBox1.Text += "dağıtabilirsiniz. "

        RichTextBox1.Text += "Kopyalamak fiili işlemi için bir ücret talep edebilir ve sizin seçiminize bağlı olarak ücret karşılığı garanti verebilirsiniz. "

        RichTextBox1.Text += "2:      .Yazılım() 'ın kopyasını veya kopyalarını veya herhangi bir parçasını değiştirerek Yazılım'ı baz alan ürün elde edebilir, "
        RichTextBox1.Text += "       bu()"
        RichTextBox1.Text += "değişiklikleri veya ürünün kendisini yukarıda 1. bölümdeki şartlar dahilinde ve aşağıda sıralanan şartların yerine "
        RichTextBox1.Text += "getirilmesi koşulu ile kopyalayabilir ve dağıtabilirsiniz. "

        RichTextBox1.Text += "a) Değiştirilen dosyaların görünür bir şekilde dosyaların sizin tarafınızdan değiştirildiğine dair, tarihli bir bildirim "
        RichTextBox1.Text += "       içermesini()"
        RichTextBox1.Text += "sağlamalısınız. "

        RichTextBox1.Text += "b) Yazılım'dan veya Yazılım'ın bir parçasından tamamen veya kısmen iştikak etmiş ve sizin tarafınızdan dağıtılan veya "
        RichTextBox1.Text += "yayınlanan herhangi bir ürünün bütün üçüncü şahıslara bu Lisans şartları altında ücretsiz olarak ruhsatlanmasını "
        RichTextBox1.Text += "sağlamalısınız. "

        RichTextBox1.Text += "c) Eğer değiştirilen yazılım olağan kullanım altında komutları interaktif olarak alıyor ise, yazılım, en olağan kullanım "
        RichTextBox1.Text += "        için()"
        RichTextBox1.Text += "interaktif olarak çalıştırıldığı zaman uygun bir telif hakkı bildirimi, garantisi olmadığına (veya sizin tarafınızdan "
        RichTextBox1.Text += "       garanti()"
        RichTextBox1.Text += "verildiğine), kullanıcıların bu yazılımı bu şartlar altında tekrar dağıtabileceklerine, ve kullanıcının bu Lisansın bir "
        RichTextBox1.Text += "        kopyasını()"
        RichTextBox1.Text += "nasıl görebileceğine dair bir bildirim yazdırmalı veya göstermelidir. (İstisna: Eğer Yazılım'ın kendisi interaktif ise "
        RichTextBox1.Text += "       fakat()"
        RichTextBox1.Text += "böyle bir bildirimi olağan kullanım esnasında yazdırmıyor ise, sizin Yazılım'ı baz alan ürününüz böyle bir bildirimde "
        RichTextBox1.Text += "bulunmak zorunda değildir.) "

        RichTextBox1.Text += "Bu şartlar değiştirilmiş eserin tamamını kapsamaktadır. Eğer eserin tespit edilebilir kısımları Yazılım'dan iştikak "
        RichTextBox1.Text += "       etmemiş()"
        RichTextBox1.Text += "ise ve makul surette kendi başlarına bağımsız ve ayrı eserler olarak kabul edilebilir ise, o zaman bu Lisans ve şartları, "
        RichTextBox1.Text += " bu()"
        RichTextBox1.Text += "parçaları ayrı eser olarak dağıttığınız zaman bağlayıcı değildir. Fakat, aynı parçaları Yazılım'ı baz alan bir ürün "
        RichTextBox1.Text += " bütününün()"
        RichTextBox1.Text += "bir parçası olarak dağıttığınız zaman bütünün dağıtımı, diğer ruhsat sahiplerine verilen izinlerin bütüne ait olduğu ve "
        RichTextBox1.Text += "parçalarına, yazarının kim olduğuna bakılmaksızın bütün parçalarına tek tek ve müşterek olarak uygulandığı bu "
        RichTextBox1.Text += "       Lisans()"
        RichTextBox1.Text += "şartlarına uygun olmalıdır. "

        RichTextBox1.Text += "Bu bölümün hedefi tamamen sizin tarafınızdan yazılan bir eser üzerinde hak iddia etmek veya sizin böyle bir eser "
        RichTextBox1.Text += "üzerindeki haklarınıza muhalefet etmek değil, Yazılım'ı baz alan, Yazılım'dan iştikak etmiş veya müşterek olarak "
        RichTextBox1.Text += "       ortaya()"
        RichTextBox1.Text += "çıkarılmış eserlerin dağıtımını kontrol etme haklarını düzenlemektir. "

        RichTextBox1.Text += "Buna ek olarak, Yazılım'ı baz almayan herhangi bir ürünün Yazılım ile (veya Yazılım'ı baz alan bir ürün ile) bir bilgi "
        RichTextBox1.Text += "saklama ortamında veya bir dağıtım ortamında beraber tutulması diğer eseri bu Lisans kapsamına sokmaz. "

        RichTextBox1.Text += "3:      .Yazılım() 'ı ( veya 2. bölümde tanımlandığı hali ile onu baz alan bir ürünü) ara derlenmiş veya uygulama hali ile 1. ve 2. "
        RichTextBox1.Text += "       Bölüm() 'deki şartlar dahilinde ve aşağıda sıralanan yöntemlerden birisine uygun olarak kopyalayabilir ve "
        RichTextBox1.Text += "dağıtabilirsiniz. "

        RichTextBox1.Text += "a) Yaygın olarak yazılım dağıtımında kullanılan bir ortam üzerinde, yukarıda 1. ve 2. Bölüm'de bulunan şartlar "
        RichTextBox1.Text += "dahilinde, "
        RichTextBox1.Text += "bilgisayar tarafından okunabilir kaynak kodlarının tamamı ile birlikte dağıtmak. "

        RichTextBox1.Text += "b)Herhangi bir üçüncü şahsa, fiziksel olarak dağıtımı gerçekleştirme masrafınızdan daha fazla ücret almayarak, "
        RichTextBox1.Text += "        yaygın()"
        RichTextBox1.Text += "olarak yazılım dağıtımında kullanılan bir ortam üzerinde, yukarıda 1. ve 2. Bölüm'de bulunan şartlar dahilinde, "
        RichTextBox1.Text += "bilgisayar()"
        RichTextBox1.Text += "tarafından okunabilir kaynak kodlarının tamamını dağıtacağınıza dair en az üç yıl geçerli olacak yazılı bir "
        RichTextBox1.Text += "       taahhütname()"
        RichTextBox1.Text += "ile birlikte dağıtmak. "

        RichTextBox1.Text += "c)Size verilmiş olan ilgili kaynak kodunu dağıtma taahhütnamesi ile birlikte dağıtmak. (Bu alternatif yalnızca ticari "
        RichTextBox1.Text += "olmayan dağıtımlar için ve yalnızca siz de yazılımı ara derlenmiş veya uygulama biçeminde ve yukarıda b) bölümünde "
        RichTextBox1.Text += "anlatılan şekli ile bir taahhütname ile birlikte almış iseniz geçerlidir.) "

        RichTextBox1.Text += "Bir eserin kaynak kodu, esere değiştirme yapmak için en uygun yöntem ve imkan anlamında kullanılmaktadır. "
        RichTextBox1.Text += "Uygulama biçeminde bir eser için, kaynak kodu, içerdiği bütün parçalar için ilgili kaynak kodları, ilgili arayüz tanım "
        RichTextBox1.Text += "dosyaları ve derleme ve yükleme işlemlerinde kullanılan bütün betikler anlamında kullanılmaktadır. Bir istisna olarak, "
        RichTextBox1.Text += "dağıtılan kaynak kodu, genelde uygulamanın üzerinde çalışacağı işletim sisteminin ana parçaları (derleyici, çekirdek "
        RichTextBox1.Text += "v.b.) ile birlikte dağıtılan herhangi bir bileşeni,eğer ilgili bileşen, uygulama ile birlikte dağıtılmıyorsa, içermek zorunda "
        RichTextBox1.Text += "değildir. "

        RichTextBox1.Text += "Eğer uygulama veya ara derlenmiş biçemde yazılımın dağıtımı belli bir yere erişim ve oradan kopyalama imkanı olarak "
        RichTextBox1.Text += "yapılıyorsa, aynı yerden, aynı koşullar altında kaynak koduna erişim imkanı sağlamak, üçüncü şahısların ara derlenmiş "
        RichTextBox1.Text += "ve uygulama biçemleri ile birlikte kaynak kodunu kopyalama zorunlulukları olmasa bile kaynak kodunu dağıtmak olarak "
        RichTextBox1.Text += "kabul edilmektedir. "

        RichTextBox1.Text += "4:      .Yazılım() 'ı bu Lisans'ta sarih olarak belirtilen şartlar haricinde kopyalayamaz, değiştiremez, ruhsat hakkını veremez "
        RichTextBox1.Text += "ve()"
        RichTextBox1.Text += "dağıtamazsınız. Buna aykırı herhangi bir kopyalama, değiştirme, ruhsat hakkı verme, veya dağıtımda bulunma "
        RichTextBox1.Text += "hükümsüzdür ve böyle bir teşebbüs halinde bu Lisans altındaki bütün haklarınız iptal edilir. Sizden, bu Lisans "
        RichTextBox1.Text += "kapsamında kopya veya hak almış olan üçüncü şahıslar, Lisans şartlarına uygunluklarını devam ettirdikleri sürece, "
        RichTextBox1.Text += "ruhsat haklarını muhafaza edeceklerdir. "

        RichTextBox1.Text += "5. Bu Lisans sizin tarafınızdan imzalanmadığı için bu Lisans'ı kabul etmek zorunda değilsiniz. Fakat, size Yazılım'ı "
        RichTextBox1.Text += "        veya()"
        RichTextBox1.Text += "onu baz alan ürünleri değiştirmek veya dağıtmak için izin veren başka bir belge yoktur. Eğer bu Lisans'ı kabul "
        RichTextBox1.Text += "etmiyorsanız bu eylemler kanun tarafından sizin için yasaklanmıştır. Dolayısıyla, Yazılım'ı (veya onu baz alan bir "
        RichTextBox1.Text += "ürünü) "
        RichTextBox1.Text += "değiştirmeniz veya dağıtmanız bu Lisans'ı ve Lisans'ın Yazılım'ı veya ondan iştikak etmiş bütün eserleri kopyalamak, "
        RichTextBox1.Text += "değiştirmek ve dağıtmak için getirdiği şart ve kayıtları kabul ettiğiniz manasına gelmektedir. "

        RichTextBox1.Text += "6:      .Yazılım() 'ı (veya onu baz alan herhangi bir ürünü) yeniden dağıttığınız her defada alıcı, ilk ruhsat sahibinden "
        RichTextBox1.Text += "       otomatik()"
        RichTextBox1.Text += "       olarak(Yazılım) 'ı bu şartlar ve kayıtlar dahilinde kopyalamak, değiştirmek ve dağıtmak için ruhsat almaktadır. Alıcının "
        RichTextBox1.Text += "burada verilen hakları kullanmasına ek bir takım kısıtlamalar getiremezsiniz. Üçüncü şahısları bu Lisans mucibince "
        RichTextBox1.Text += "hareket etmeğe mecbur etmek sizin sorumluluk ve yükümlülüğünüz altında değildir. "

        RichTextBox1.Text += "7. Eğer bir mahkeme kararı veya patent ihlal iddiası veya herhangi başka bir (patent meseleleri ile sınırlı olmayan) "
        RichTextBox1.Text += "       sebep()"
        RichTextBox1.Text += "sonucunda size, bu Lisans'ın şart ve kayıtlarına aykırı olan bir takım (mahkeme kararı, özel anlaşma veya başka bir "
        RichTextBox1.Text += "şekilde) kısıtlamalar getirilirse, bu sizi bu Lisans şart ve kayıtlarına uyma mecburiyetinden serbest bırakmaz. Eğer "
        RichTextBox1.Text += "   aynı()"
        RichTextBox1.Text += "anda hem bu Lisans'ın şartlarını yerine getiren hem de diğer kısıtlamalara uygun olan bir şekilde Yazılım'ı "
        RichTextBox1.Text += "dağıtamıyorsanız, o zaman Yazılım'ı dağıtamazsınız. Örneğin, eğer bir patent lisansı direkt veya endirekt olarak "
        RichTextBox1.Text += "       sizden()"
        RichTextBox1.Text += "kopya alacak olan üçüncü şahısların bedel ödemeksizin Yazılım'ı dağıtmalarına hak tanımıyorsa o zaman sizin hem bu "
        RichTextBox1.Text += "koşulu hem Lisans koşullarını yerine getirmenizin tek yolu Yazılım'ı dağıtmamak olacaktır. "

        RichTextBox1.Text += "Eğer bu bölümün herhangi bir parçası herhangi bir şart altında uygulanamaz veya hatalı bulunur ise o şartlar "
        RichTextBox1.Text += "       dahilinde()"
        RichTextBox1.Text += "bölümün geri kalan kısmı, bütün diğer şartlar altında da bölümün tamamı geçerlidir. "

        RichTextBox1.Text += "Bu bölümün amacı sizin patent haklarını, herhangi bir mülkiyet hakkını ihlal etmenize yol açmak veya bu hakların "
        RichTextBox1.Text += "geçerliliğine muhalefet etmenizi sağlamak değildir; bu bölümün bütün amacı kamu lisans uygulamaları ile oluşturulan "
        RichTextBox1.Text += "serbest yazılım dağıtım sisteminin bütünlüğünü ve işlerliğini korumaktır. Bu sistemin tutarlı uygulanmasına dayanarak "
        RichTextBox1.Text += "        pek()"
        RichTextBox1.Text += "çok kişi bu sistemle dağıtılan geniş yelpazedeki yazılımlara katkıda bulunmuştur; yazılımını bu veya başka bir sistemle "
        RichTextBox1.Text += "dağıtmak kararı yazara aittir, herhangi bir kullanıcı bu kararı veremez. "

        RichTextBox1.Text += "Bu bölüm Lisans'ın geri kalanının doğurduğu sonuçların ne olduğunu açıklığa kavuşturmak amacını gütmektedir. "

        RichTextBox1.Text += "8:      .Eğer(Yazılım) 'ın kullanımı ve/veya dağıtımı bazı ülkelerde telif hakkı taşıyan arayüzler veya patentler yüzünden "
        RichTextBox1.Text += "        kısıtlanırsa, Yazılım 'ı bu Lisans kapsamına ilk koyan telif hakkı sahibi, Yazılım'ın yalnızca bu ülkeler haricinde "
        RichTextBox1.Text += "dağıtılabileceğine dair açık bir coğrafi dağıtım kısıtlaması koyabilir. Böyle bir durumda bu Lisans bu kısıtlamayı sanki "
        RichTextBox1.Text += "        Lisans() 'ın içerisine yazılmış gibi kapsar. "

        RichTextBox1.Text += "9. Free Software Foundation zaman zaman Genel Kamu Lisansı'nın yeni ve/veya değiştirilmiş biçimlerini "
        RichTextBox1.Text += "yayınlayabilir. "
        RichTextBox1.Text += "Böyle yeni sürümler mana olarak şimdiki haline benzer olacaktır, fakat doğacak yeni problemler veya kaygılara cevap "
        RichTextBox1.Text += "verecek şekilde detayda farklılık arzedebilir. "

        RichTextBox1.Text += "Her yeni biçime ayırdedici bir sürüm numarası verilmektedir. Eğer Yazılım bir sürüm numarası belirtiyor ve bu ve "
        RichTextBox1.Text += "       bundan()"
        RichTextBox1.Text += "sonraki sürümler altında dağıtılıyorsa, belirtilen sürüm veya Free Software Foundation tarafından yayınlanan "
        RichTextBox1.Text += "       herhangi()"
        RichTextBox1.Text += "sonraki bir sürümün şart ve kayıtlarına uymakta serbestsiniz. Eğer Yazılım Lisans için bir sürüm numarası belirtmiyor "
        RichTextBox1.Text += "ise, "
        RichTextBox1.Text += "Free Software Foundation tarafından yayınlanmış olan herhangi bir sürümün şart ve kayıtlarına uymakta "
        RichTextBox1.Text += "serbestsiniz. "

        RichTextBox1.Text += "10. Eğer bu Yazılım'ın parçalarını dağıtım koşulları farklı olan başka serbest yazılımların içerisinde kullanmak "
        RichTextBox1.Text += "isterseniz, "
        RichTextBox1.Text += "yazara sorarak izin isteyin. Telif hakkı Free Software Foundation'a ait olan yazılımlar için Free Software "
        RichTextBox1.Text += "        Foundation() 'a "
        RichTextBox1.Text += "yazın, bazen istisnalar kabul edilmektedir. Kararımız, serbest yazılımlarımızdan iştikak etmiş yazılımların serbest "
        RichTextBox1.Text += "      statülerini()"
        RichTextBox1.Text += "korumak ve genel olarak yazılımların yeniden kullanılabilirliğini ve paylaşımını sağlamak amaçları doğrultusunda "
        RichTextBox1.Text += "şekillenecektir. "

        RichTextBox1.Text += "       GARANTİ(YOKTUR)"
        RichTextBox1.Text += "11. Bu yazılım ücretsiz olarak ruhsatlandığı için, yazılım için ilgili kanunların izin verdiği ölçüde herhangi bir garanti "
        RichTextBox1.Text += "verilmemektedir. Aksi yazılı olarak belirtilmediği müddetçe telif hakkı sahipleri ve/veya başka şahıslar yazılımı "
        RichTextBox1.Text += "olduğu "
        RichTextBox1.Text += "        gibi(, aşikar veya zimnen, satılabilirliği veya herhangi bir amaca uygunluğu da dahil olmak üzere hiçbir garanti "
        RichTextBox1.Text += "vermeksizin dağıtmaktadırlar. Yazılımın kalitesi veya performansı ile ilgili tüm sorunlar size aittir. Yazılımda herhangi "
        RichTextBox1.Text += "        bir()"
        RichTextBox1.Text += "bozukluktan dolayı doğabilecek olan bütün servis, tamir veya düzeltme masraflari size aittir. "

        RichTextBox1.Text += "12. İlgili kanunun icbar ettiği durumlar veya yazılı anlaşma haricinde herhangi bir şekilde telif hakkı sahibi veya "
        RichTextBox1.Text += "       yukarıda()"
        RichTextBox1.Text += "izin verildiği şekilde yazılımı değiştiren veya yeniden dağıtan herhangi bir kişi, yazılımın kullanımı veya "
        RichTextBox1.Text += "        kullanılamaması()"
        RichTextBox1.Text += "(veya veri kaybı oluşması, verinin yanlış hale gelmesi, sizin veya üçüncü şahısların zarara uğraması veya yazılımın "
        RichTextBox1.Text += "başka yazılımlarla beraber çalişamaması) yüzünden oluşan genel, özel, doğrudan ya da dolaylı herhangi bir zarardan, "
        RichTextBox1.Text += "böyle bir tazminat talebi telif hakkı sahibi veya ilgili kişiye bildirilmiş olsa dahi, sorumlu değildir. "

        RichTextBox1.Text += "ŞART VE KAYITLARIN SONU  GNU"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class