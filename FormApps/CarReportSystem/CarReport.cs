namespace CarReportSystem {
    public class CarReport {
        //列挙型
        public enum MakerGroup {
            なし = 0,
            トヨタ = 1,
            日産 = 2,
            ホンダ = 3,
            スバル = 4,
            輸入車 = 5,
            その他 = 6,
        }
        [System.ComponentModel.DisplayName("Id")]
        public int Id { get; set; }   //カーレポートID
        [System.ComponentModel.DisplayName("日付")]
        public DateTime Date { get; set; }   //日付
        [System.ComponentModel.DisplayName("記録者")]
        public string Author { get; set; } = string.Empty;   //記録者
        [System.ComponentModel.DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }   //メーカー
        [System.ComponentModel.DisplayName("車名")]
        public string CarName { get; set; } = string.Empty;   //車名
        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; } = string.Empty;   //レポート
        [System.ComponentModel.DisplayName("画像")]
        public Image? Picture { get; set; }   //画像
    }
}