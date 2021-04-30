namespace sempt3x_Port_Scanner
{
    public class CheckStatus {
        //** Define Variables **//
        private string _ipeingabe = "";
        private int _port1, _port2;

        private bool _checkinput1 = true, _checkinput2 = true, _checkinput3 = true;
        //** Reset Method **//
        public string Ipeingabe
        {
            get => _ipeingabe;
            set => _ipeingabe = value;
        }
        public int Port1
        {
            get => _port1;
            set => _port1 = value;
        }
        public int Port2
        {
            get => _port2;
            set => _port2 = value;
        }
        public bool Checkinput1
        {
            get => _checkinput1;
            set => _checkinput1 = value;
        }
        public bool Checkinput2
        {
            get => _checkinput2;
            set => _checkinput2 = value;
        }
        public bool  Checkinput3
        {
            get => _checkinput3;
            set => _checkinput3 = value;
        }
    }
}