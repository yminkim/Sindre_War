using System;
using System.Threading;

namespace RedMoon_v._01
{
    class Program
    {
        public class Info
        {
            //////////////////////////////////////
            ///           변수보관소           ///
            //////////////////////////////////////
            /// 개인 프로젝트 이기 때문에
            /// 접근제한자는 public으로 통일
            ///  (⁰︻⁰)  프링글스 맨
            public string _name;
            public string _jobName;
            public string _face;   

            public int _level;
            public int _life;
            public int _gold;

            public double _hp;
            public double _maxHp;
            public double _exp;
            public double _maxExp;
            public double _mana;
            public double _maxMana;
            public double _str;

             // 무기 방어구 스탯은 대기
            //////////////////////////////////////
            //////////////////////////////////////



        } // Info End

        public class Player : Info
        {
            public void NickName()
            {
                Console.Clear();
                bool nickNameBool = true;
                while (nickNameBool)
                {
                    Console.Clear();
                    Console.WriteLine("당신의 이름은 무엇인가요? (7글자 이내)");
                    Console.Write("입력:");


                    string inputName = Console.ReadLine();
                    if (inputName.Length < 7)
                    {
                        _name = inputName;
                        nickNameBool = false;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("7글자 이내로 입력해주세요.");
                        Thread.Sleep(1200);
                    }


                } // while end
            } // Nickname() End

            public void Job()
            {
                bool ChooseJob = true;
                while (ChooseJob)
                {
                    Console.Clear();
                    Console.WriteLine("┌───────────────────┐");
                    Console.WriteLine("│ 직업을 골라주세욥!│");
                    Console.WriteLine("├───────────────────┴──────────────────┐");
                    Console.WriteLine("│①전사  : 체력 75 | 공격력 6 | 마나 40│");
                    Console.WriteLine("│②도적  : 체력 60 | 공격력 6 | 마나 50│");
                    Console.WriteLine("│③마법사: 체력 50 | 공격력 6 | 마나 60│");
                    Console.WriteLine("└──────────────────────────────────────┘");
                    Console.WriteLine("");

                    string inputJob = Console.ReadLine();
                    switch(inputJob)
                    {
                        case "1" :
                            _jobName = "전사";
                            _face = "(`ㅂ’)";
                            _life = 2;
                            _level = 1;
                            _maxHp = 75;
                            _hp = _maxHp;
                            _str = 6;
                            _maxExp = 100;
                            _exp = 0;
                            _maxMana = 40;
                            _mana = _maxMana;
                            _gold = 10000;
                            ChooseJob = false;
                            break;

                        case "2" :
                            _jobName = "도적";
                            _face = "눈_눈";
                            _life = 2;
                            _level = 1;
                            _maxHp = 60;
                            _hp = _maxHp;
                            _str = 6;
                            _maxExp = 100;
                            _exp = 0;
                            _maxMana = 50;
                            _mana = _maxMana;
                            _gold = 10000;
                            ChooseJob = false;
                            break;
                        case "3" :
                            _jobName = "마법사";
                            _face = "±∇±";
                            _life = 2;
                            _level = 1;
                            _maxHp = 50;
                            _hp = _maxHp;
                            _str = 6;
                            _maxExp = 100;
                            _exp = 0;
                            _maxMana = 60;
                            _mana = _maxMana;
                            _gold = 10000;
                            ChooseJob = false;
                            break;

                        default :
                            break;

                    } // switch end
                } //while end
            } // Job() End



        } // class Player End

        public class Monster : Info
        {

        } // class Monster End
        static void Main(string[] args)
        {
            Info info = new Info();
            Player player = new Player();
            Monster mon = new Monster();

            // 프롤로그 만들기~(스킵기능도)

            player.NickName();
            player.Job();
            Console.Clear();
            Console.WriteLine($"어서오세요 {player._jobName} {player._name}님");
            Thread.Sleep(1200);

            while (true) //전체 while 
            {
                Console.Clear();
                Console.WriteLine("[내정보]");
                Console.WriteLine($"Lv.{player._level} {player._jobName} {player._name}");
                Console.WriteLine("EXP: {0:F0}/{1:F0}", player._exp, player._maxExp);
                Console.WriteLine("목숨: {0}", player._life);
                Console.WriteLine("체력: {0:F0}/{1:F0}", player._hp, player._maxHp);
                Console.WriteLine("공격력: {0:F0}", player._str);
                Console.WriteLine("마나: {0:F0}/{1:F0}", player._mana, player._maxMana);
                Console.WriteLine("골드: {0}", player._gold);
                Console.WriteLine("");
                Console.WriteLine("[마을]");
                Console.WriteLine("┌──────────────────────────┐");
                Console.WriteLine("│ 1.광장  2.상점  3.대장간 │");
                Console.WriteLine("│ 4.병원  5.던전  6.광산   │");
                Console.WriteLine("└──────────────────────────┘");

                string inputMenu = Console.ReadLine();
                switch(inputMenu)
                {
                    case "1"://광장
                        break;

                    case "2"://상점
                        break;

                    case "3": //대장간
                        break;

                    case "4": //병원
                        break;

                    case "5": // 던전
                        bool boolDGmenu = true;
                        while (boolDGmenu)
                        {
                            Console.Clear();
                            Console.WriteLine("[던전]");
                            Console.WriteLine("1. 고블린동굴");
                            Console.WriteLine("2. 검은숲");
                            Console.WriteLine("3. 검은탑");
                            Console.WriteLine("");
                            Console.WriteLine("0. 뒤로가기");
                            // 마계의 문
                            Console.WriteLine("");
                            string inputDungeon = Console.ReadLine();
                            switch (inputDungeon)
                            {
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "0":
                                    boolDGmenu = false;
                                    break;
                                default:
                                    break;

                            }// input Dungeon end
                        }//while end
                        break;
                    case "6": // 광산
                        break;

                    default:
                        break;

                } // menu switch end
                
            } // 태초의 while E.N.D !!!!!!!!

             
           


        } //main END
    } // Class Program End
} // namespace End
