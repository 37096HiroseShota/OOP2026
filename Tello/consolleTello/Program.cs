using Tello.Net.Entities.Connection;
using Tello.Net.Entities.ControlCommand;
using Tello.Net.Entities.Drone;

namespace consoleTello;

class Program {
    static TelloConnection connection = new TelloConnection();
    static TelloDrone drone = new TelloDrone(connection);

    /***********************************************/
    /***** 経路プログラム **************************/
    /***********************************************/

    static void Main(string[] args) {
    }

    /***********************************************/
    /***** 各種の動作 ******************************/
    /***********************************************/

    /******* ドローンとの接続 ***********/
    static void Coneect() {
        try {
            connection.Connect("192.168.10.1", 8889);
            if (drone != null) Console.WriteLine($"[{drone}]Connected!");
        } catch {
            connection.Disconnect();
            Console.WriteLine("Cannot Connect...");
        }
    }

    /******* ドローンとの接続解除 ***********/
    static void DisConnect() {
        try {
            Hover();
            connection.Disconnect();
            Console.WriteLine("Connection End.");
        } catch {
        }
    }

    /******* ホバー(空中停止) ***********/
    static void Hover() {
        drone.SendCommand(new RcCommand(0, 0, 0, 0));
        drone.SendCommand(new StopCommand());
        drone.Wait(500);
    }

    /******* 離陸 ***********/
    static void TakeOff() {
        drone.SendCommand(new TakeoffCommand());
        drone.Wait(1500);
        Hover();
    }

    /******* 着陸 ***********/
    static void Land() {
        Hover();
        drone.SendCommand(new LandCommand());
        drone.Wait(2000);
    }

    /******* 前進 ***********/
    static void Forward(int cm) {
        drone.SendCommand(new RcCommand(0, cm, 0, 0));
        drone.Wait(1000);
        Hover();
    }

    /******* 後進 ***********/
    static void Backward(int cm) {
        drone.SendCommand(new RcCommand(0, -cm, 0, 0));
        drone.Wait(1000);
        Hover();
    }

    /******* 上昇 ***********/
    static void Up(int cm) {
        drone.SendCommand(new RcCommand(0, 0, cm, 0));
        drone.Wait(1000);
        Hover();
    }

    /******* 下降 ***********/
    static void Down(int cm) {
        drone.SendCommand(new RcCommand(0, 0, -cm, 0));
        drone.Wait(1000);
        Hover();
    }

    /******* 右へスライド ***********/
    static void Right(int cm) {
        drone.SendCommand(new RcCommand(cm, 0, 0, 0));
        drone.Wait(1000);
        Hover();
    }

    /******* 左へスライド ***********/
    static void Left(int cm) {
        drone.SendCommand(new RcCommand(-cm, 0, 0, 0));
        drone.Wait(1000);
        Hover();
    }

    /******* 右旋回 ***********/
    static void ClockWise(int yaw) {
        drone.SendCommand(new RcCommand(0, 0, 0, yaw));
        drone.Wait(1000);
        Hover();
    }

    /******* 左旋回 ***********/
    static void AntiClockWise(int yaw) {
        drone.SendCommand(new RcCommand(0, 0, 0, -yaw));
        drone.Wait(1000);
        Hover();
    }
}