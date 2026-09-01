using System.ComponentModel;

namespace Temp01 {
    public class User {
        [DisplayName("ユーザーID")]
        public String Id { get; set; }

        [DisplayName("ユーザー名")]
        public String Name { get; set; }
    }
}
