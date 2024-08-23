namespace CA_Football
{
    internal class Keeper : Player
    {//Kaleci
        override public string Run(int value)
        {
            if (50 > value)
            {
                return "Düşük isabet, koşmaya çalışırken ayağı takıldı";
            }
            else if (50 <= value && 60 > value)
            {
                return "Zayıf isabet, koşarken yoruldu";
            }
            else if (60 <= value && 70 > value)
            {
                return "Normal isabet, yorulmadan koştu";
            }
            else if (70 <= value && 80 > value)
            {
                return "Orta isabet, hızlı koşuyor";
            }
            else if (80 <= value && 90 > value)
            {
                return "Yüksek isabet, çok hızlı koşuyor durmak bilmiyor";
            }
            else if (90 <= value && 100 > value)
            {
                return "Ulti isabet, çok hızlı koşuyor ondan hızlısı mezarda";
            }
            else
            {
                return "";
            }
        }

        public override string Shoot(int value)
        {
            if (50 > value)
            {
                return "Düşük isabet, şut atacakken yerde kaydı ve düştü";
            }
            else if (50 <= value && 60 > value)
            {
                return "Zayıf isabet, şutu kaçırdı";
            }
            else if (60 <= value && 70 > value)
            {
                return "Normal isabet, şut attı";
            }
            else if (70 <= value && 80 > value)
            {
                return "Orta isabet, şut attı top istenilen yere gitti";
            }
            else if (80 <= value && 90 > value)
            {
                return "Yüksek isabet, güçlü bir şut attı top rakip kale yakınlarında";
            }
            else if (90 <= value && 100 > value)
            {
                return "Ulti isabet, çok güçlü bir şut top rakip kaleyi zorluyor";
            }
            else
            {
                return "";
            }
        }

        public override string Feint(int value)
        {
            if (50 > value)
            {
                return "Düşük isabet, çalım atarken topu kaybetti";
            }
            else if (50 <= value && 60 > value)
            {
                return "Zayıf isabet, çalım atarken topu rakibe kaptırdı";
            }
            else if (60 <= value && 70 > value)
            {
                return "Normal isabet, çalım atarken rakibi geçti";
            }
            else if (70 <= value && 80 > value)
            {
                return "Orta isabet, çalım atarken rakibi ters köşeye yatırdı";
            }
            else if (80 <= value && 90 > value)
            {
                return "Yüksek isabet, çalım atarken rakibi ters köşeye yatırdı ve gol attı";
            }
            else if (90 <= value && 100 > value)
            {
                return "Ulti isabet, çalım atarken rakibi ters köşeye yatırdı ve gol attı, rakip kaleci bile şaşkın";
            }
            else
            {
                return "";
            }
        }

        public override string Pressing(int value)
        {
            if (50 > value)
            {
                return "Düşük isabet, topu alamadı";
            }
            else if (50 <= value && 60 > value)
            {
                return "Zayıf isabet, topu almak için çaba gösterdi ama alamadı";
            }
            else if (60 <= value && 70 > value)
            {
                return "Normal isabet, topu almak için çaba gösterdi ve aldı";
            }
            else if (70 <= value && 80 > value)
            {
                return "Orta isabet, topu almak için çaba gösterdi ve aldı, rakip takımın hücumunu engelledi";
            }
            else if (80 <= value && 90 > value)
            {
                return "Yüksek isabet, topu almak için çaba gösterdi ve aldı, rakip takımın hücumunu engelledi ve kendi takımının hücumunu başlattı";
            }
            else if (90 <= value && 100 > value)
            {
                return "Ulti isabet, topu almak için çaba gösterdi ve aldı, rakip takımın hücumunu engelledi ve kendi takımının hücumunu başlattı, gol attı";
            }
            else
            {
                return "";
            }
        }
        public string SaveBall(int value)
        {
            if (50 > value)
            {
                return "Düşük isabet, topu tutamadı";
            }
            else if (50 <= value && 60 > value)
            {
                return "Zayıf isabet, topu tutmaya çalıştı ama tutamadı";
            }
            else if (60 <= value && 70 > value)
            {
                return "Normal isabet, topu tuttu";
            }
            else if (70 <= value && 80 > value)
            {
                return "Orta isabet, topu tuttu ve hemen hücum başlattı";
            }
            else if (80 <= value && 90 > value)
            {
                return "Yüksek isabet, topu tuttu ve hemen hücum başlattı, rakip takımın hücumunu engelledi";
            }
            else if (90 <= value && 100 > value)
            {
                return "Ulti isabet, topu tuttu ve hemen hücum başlattı, rakip takımın hücumunu engelledi ve kendi takımının hücumunu başlattı";
            }
            else
            {
                return "";

            }
        }
    }
}