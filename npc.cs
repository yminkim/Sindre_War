using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
/// <summary>
// 대화할 때 다다다닫다 스크립트 만들기~!!
/// </summary>
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
            bool boolBT1 = true; // 배틀 시작 불
            public string _name;
            public string _jobName;
            public string _face;
            public string _opScript;

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

            public int _hp3 = 0;
            public int _hp10 = 0;
            public int _mp3 = 2;
            public int _mp10 = 0;


            public int skillC;
            bool boolWskill = true;
            // 무기 방어구 스탯은 대기
            //////////////////////////////////////
            //////////////////////////////////////

            public void BattleInfo(Info _attacker, Info _target)
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine($"[{_target._name}]");
                //_target.hpVar();
                Console.WriteLine($"◎체력   : {_target._hp:F0}/{_target._maxHp:F0}");
                Console.WriteLine($"◎공격력 : {_target._str:F0}");
                Console.WriteLine("====================");
                Console.WriteLine($"{_target._face}\n\n");

                Console.WriteLine($"             {_attacker._face}");
                Console.WriteLine("====================");
                Console.WriteLine($"[Lv.{_attacker._level} {_attacker._name}]");
                //attacker.hpVar();
                Console.WriteLine($"◎목숨   : {_attacker._life}");
                Console.WriteLine($"◎체력   : {_attacker._hp:F0}/{_attacker._maxHp:F0}");
                Console.WriteLine($"◎공격력 : {_attacker._str:F0}");
                Console.WriteLine($"◎마나   : {_attacker._mana:F0}/{_attacker._maxMana:F0}");
                Console.WriteLine("====================");
            }
            ///////////////////////////////////////
            //대사 출력
            public void PrintSct(string sct)
            {
                Console.Clear();
                string printsct = sct;
                for (int i = 0; i < printsct.Length; i++)
                {
                    Console.Write(printsct[i]);
                    Thread.Sleep(30);
                }
                Console.WriteLine("\n\n 확인");
                Console.ReadLine();
            }

            ///////////////////////////////////////
            //스킬
            public void SkillAttack(Info _attacker, Info _target, double skillDmg, double useMana, string skillName)
            {
                double y = skillDmg;
                double x = useMana;
                string z = skillName;

                skillC = 1;
                Console.Clear();
                if (_attacker._mana >= x)
                {
                    Console.WriteLine(z);
                    Thread.Sleep(1400);
                    _attacker._mana -= x;
                    _target._hp -= (_attacker._str * y);

                    if (_target._hp <= 0)
                    {
                        _target._hp = 0;
                    }
                    boolWskill = false;
                }
                else
                {
                    skillC = 0;
                    Console.Clear();
                    Console.WriteLine("마나가 부족합니다.");
                    Thread.Sleep(1400);
                }
                
            }
            public void Wskill(Info _attacker, Info _target)
            {
                boolWskill = true;
                while(boolWskill)
                {
                    skillC = 0;
                    Console.Clear();
                    Console.WriteLine("[스킬]");
                    if (_attacker._jobName == "전사")
                    {
                        Console.WriteLine("1. 전사 스킬1");  // 스킬명 마나소모량 딜량  표기 
                        Console.WriteLine("2. 전사 스킬2");
                        Console.WriteLine("3. 전사 스킬3");
                    }
                    if (_attacker._jobName == "도적")
                    {
                        Console.WriteLine("1. 도적 스킬1");
                        Console.WriteLine("2. 도적 스킬2");
                        Console.WriteLine("3. 도적 스킬3");
                    }
                    if (_attacker._jobName == "마법사")
                    {
                        Console.WriteLine("1. 마법사 스킬1");
                        Console.WriteLine("2. 마법사 스킬2");
                        Console.WriteLine("3. 마법사 스킬3");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("0.뒤로가기");
                    
                    string inputSkillW = Console.ReadLine();
                    switch(inputSkillW)
                    {
                        case "1":  //  SkillAttack(_a / _t / 대미지 / 마나 / 대사)
                            if (_attacker._jobName == "전사")
                                SkillAttack(_attacker, _target, 1.2, 10, "전사스킬 1 발동!");
                            if (_attacker._jobName == "도적")
                                SkillAttack(_attacker, _target, 2.0, 20, "도적스킬 1 발동!");
                            if (_attacker._jobName == "마법사")
                                SkillAttack(_attacker, _target, 2.5, 30, "마법사 스킬 1 발동!");
                            break;

                        case "2":
                            if (_attacker._jobName == "전사")
                                SkillAttack(_attacker, _target, 1.2, 10, "전사스킬 2 발동!");
                            if (_attacker._jobName == "도적")
                                SkillAttack(_attacker, _target, 2.0, 20, "도적스킬 2 발동!");
                            if (_attacker._jobName == "마법사")
                                SkillAttack(_attacker, _target, 2.5, 30, "마법사 스킬 2 발동!");
                            break;

                        case "3":
                            if (_attacker._jobName == "전사")
                                SkillAttack(_attacker, _target, 1.2, 10, "전사스킬 3 발동!");
                            if (_attacker._jobName == "도적")
                                SkillAttack(_attacker, _target, 2.0, 20, "도적스킬 3 발동!");
                            if (_attacker._jobName == "마법사")
                                SkillAttack(_attacker, _target, 2.5, 30, "마법사 스킬 3 발동!");
                            break;

                        case "0":
                            boolWskill = false;
                            break;
                    }//switch end
                    
                }// while end
            }// 전사 스킬 end

            ///////////////////////////////////////
            public void PlayerFight(Info _attacker, Info _target)
            {
                Random ranStr = new Random();
                int rStr = ranStr.Next(1, 10);
                if (rStr == 1) // 치뎀
                {
                    _target._hp = _target._hp - (_attacker._str * 1.2);
                    Console.Clear();
                    Console.WriteLine(_attacker._name + "(이)가 공격합니다!");
                    Thread.Sleep(1100);
                    Console.Clear();
                    Console.WriteLine("급소를 공격했다!");
                    Thread.Sleep(1100);
                    Console.Clear();
                }

                else
                {
                    _target._hp -= _attacker._str;
                    Console.Clear();
                    Console.WriteLine(_attacker._name + "(이)가 공격합니다!");
                    Thread.Sleep(1100);
                    Console.Clear();
                }
                if (_target._hp <= 0)
                {
                    _target._hp = 0;
                    
                }

            } // plyaer fight end

            ////////////////////////////////////////
            public void MonsterFight(Info _attacker, Info _target)
            {
                Random ranStr = new Random();
                int rStr = ranStr.Next(1, 10);
                if (rStr == 1) // 치뎀
                {
                    _target._hp = _target._hp - (_attacker._str * 1.3);
                    Console.Clear();
                    Console.WriteLine(_attacker._name + "(이)가 강하게 공격해온다.");
                    Thread.Sleep(1100);
                    Console.Clear();
                    Console.WriteLine("급소에 정확히 명중했다.");
                    Thread.Sleep(1100);
                    Console.Clear();
                }

                else
                {
                    _target._hp -= _attacker._str;
                    Console.Clear();
                    Console.WriteLine(_attacker._name + "(이)가 공격을 합니다.");
                    Thread.Sleep(1100);
                    Console.Clear();
                }

                if (_target._hp <= 0)
                {
                    if (_target._life >= 1)
                    {
                        _target._life -= 1;
                        _target._hp = _target._maxHp;
                    }
                }

            } // monster fight end

            ////////////////////////////////////////
            public void BattleMenu()
            {
                Console.WriteLine("┌──────────────────────────┐");
                Console.WriteLine("│   무엇을 하시겠습니까?   │");
                Console.WriteLine("├──────────────────────────┤");
                Console.WriteLine("│  1.전투  2.가방  3.도망  │");
                Console.WriteLine("└──────────────────────────┘");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            /////////////////////////////////////////
            public void LevelUp(Info _attatcker)
            {
                Console.Clear();
                Console.WriteLine("LEVEL UP!!");
                Thread.Sleep(1400);
                
                    Console.Clear();
                    Console.WriteLine("[스탯 증가]");
                    Console.WriteLine($"◈레벨  : {_attatcker._level} ▶ {_attatcker._level+1}");
                    Console.WriteLine($"◈경험치: {_attatcker._maxExp:F0} ▶ {_attatcker._maxExp+50:F0}");
                    Console.WriteLine($"◈체력  : {_attatcker._maxHp:F0} ▶ {_attatcker._maxHp*1.2:F0}");
                    Console.WriteLine($"◈공격력: {_attatcker._str:F0} ▶ {_attatcker._str*1.2:F0}");
                    Console.WriteLine($"◈마나  : {_attatcker._maxMana:F0} ▶ {_attatcker._maxMana*1.2:F0}");

                    Console.WriteLine("\n0. 확인");
                    

                    _attatcker._exp = 0;
                    _attatcker._maxExp +=50;
                    _attatcker._level += 1;

                    _attatcker._maxHp *= 1.2;
                    double maxHHp = _attatcker._maxHp;
                    _attatcker._hp = maxHHp;

                    _attatcker._maxMana *= 1.2;
                    double maxMMp = _attatcker._maxMana;
                    _attatcker._mana = maxMMp;

                    _attatcker._str *= 1.2;

                Console.ReadLine();

            }
            /////////////////////////////////////////
            public void BattleResult(Info _attatcker, Info _target)
            {
                if(_attatcker._life == 0)
                {
                    _attatcker._life = 1;
                    _attatcker._hp = _attatcker._maxHp * 0.1;
                    Console.Clear();
                    Console.WriteLine("사망하셨습니다.");
                    Thread.Sleep(1400);
                    boolBT1 = false;
                }

                if(_target._hp <=0)
                {
                    _attatcker._exp += _target._exp;
                    _attatcker._gold += _target._gold;
                    Console.Clear();
                    Console.WriteLine("승리하셨습니다.");
                    Thread.Sleep(1400);
                    Console.Clear();
                    Console.WriteLine("[보상]");
                    Console.WriteLine($"골드  : +{_target._gold}");
                    Console.WriteLine($"경험치: +{_target._exp}");
                    Console.WriteLine("\n0.확인");
                    Console.ReadLine();
                    if (_attatcker._exp >= _attatcker._maxExp)
                        LevelUp(_attatcker);
                    boolBT1 = false;
                }

            }// bresult end
            /////////////////////////////////////////

            public void BattleMain(Info _attacker, Info _target)
            {
                PrintSct($"{_target._name}: {_target._opScript}");
                boolBT1 = true;
                while(boolBT1)
                {
                    Random runaway = new Random();
                    int runawayo = runaway.Next(1, 6);
                    Console.Clear();
                    BattleInfo(_attacker, _target);
                    BattleMenu();

                    string inputBattleMenu = Console.ReadLine();
                    switch(inputBattleMenu)
                    {
                        ////////////////////
                        case "1": // 전투
                            bool boolFight1 = true;
                            while(boolFight1)
                            {
                                Console.Clear();
                                Console.WriteLine("[전투]");
                                Console.WriteLine("1. 평타");
                                Console.WriteLine("2. 스킬");
                                Console.WriteLine("");
                                Console.WriteLine("0. 뒤로가기");

                                string inputHowFight = Console.ReadLine();
                                switch(inputHowFight)
                                {
                                    case "1": //평타 << 아직 전투 테스트 안함tc만들고 ㄱㄱ
                                        PlayerFight(_attacker, _target);
                                        BattleInfo(_attacker, _target);
                                        Thread.Sleep(1300);
                                        if (_target._hp <= 0)
                                            boolFight1 = false;
                                        else
                                            MonsterFight(_target, _attacker);
                                        boolFight1 = false;

                                        break;
                                    ////////////////////
                                    case "2": //스킬
                                        Wskill(_attacker, _target);
                                        if (skillC == 1)
                                        {
                                            BattleInfo(_attacker, _target);
                                            Thread.Sleep(1300);
                                            if (_target._hp <= 0)
                                                boolFight1 = false;
                                            else
                                                MonsterFight(_target, _attacker);
                                            boolFight1 = false;
                                        }
                                        break;
                                    ////////////////////
                                    case "0":
                                        boolFight1 = false;
                                        break;
                                    ////////////////////
                                    default:
                                        break;
                                } // how fight switch end
                            } // 전투메뉴 while 엔드
                            //BattleResult(_attacker, _target);
                            break;
                        ////////////////////
                        case "2": // 가방
                            bool boolBag = true; // 불백?ㅋㅋㅋㅋ
                            while(boolBag)
                            {
                                Console.Clear();
                                Console.WriteLine("[HP & MP]");
                                Console.WriteLine($"체력: {_attacker._hp:F0}/{_attacker._maxHp:F0}");
                                Console.WriteLine($"마나: {_attacker._mana:F0}/{_attacker._maxMana:F0}");
                                Console.WriteLine("");
                                Console.WriteLine("[가방]");
                                Console.WriteLine($"1. 이둔의 사과(+30HP)[{_attacker._hp3}]");
                                Console.WriteLine($"2. 이둔의 황금사과(+100HP)[{_attacker._hp10}]");
                                Console.WriteLine($"3. 봉밀주(+30MP)[{_attacker._mp3}]");
                                Console.WriteLine($"4. 핏빛 봉밀주(+100MP)[{_attacker._mp10}]");
                                Console.WriteLine("");
                                Console.WriteLine("0.뒤로가기");
                                
                                string inputBag = Console.ReadLine();
                                switch(inputBag)
                                {
                                    case "1":
                                        Console.Clear();
                                        if (_attacker._hp3 >= 1)
                                        {
                                            _attacker._hp3 -= 1;
                                            _attacker._hp += 30;
                                            if (_attacker._hp >= _attacker._maxHp)
                                                _attacker._hp = _attacker._maxHp;
                                            Console.WriteLine("체력이 회복되었습니다.");
                                            Thread.Sleep(1350);
                                        }
                                        else
                                        {
                                            Console.WriteLine("사과가 부족합니다.");
                                            Thread.Sleep(1350);
                                        }
                                        break;

                                    case "2":
                                        Console.Clear();
                                        if (_attacker._hp10 >= 1)
                                        {
                                            _attacker._hp10 -= 1;
                                            _attacker._hp += 100;
                                            if (_attacker._hp >= _attacker._maxHp)
                                                _attacker._hp = _attacker._maxHp;
                                            Console.WriteLine("체력이 회복되었습니다.");
                                            Thread.Sleep(1350);
                                        }
                                        else
                                        {
                                            Console.WriteLine("사과가 부족합니다.");
                                            Thread.Sleep(1350);
                                        }
                                        break;

                                    case "3":
                                        Console.Clear();
                                        if (_attacker._mp3 >= 1)
                                        {
                                            _attacker._mp3 -= 1;
                                            _attacker._mana += 30;
                                            if (_attacker._mana >= _attacker._maxMana)
                                                _attacker._mana = _attacker._maxMana;
                                            Console.WriteLine("마나가 회복되었습니다.");
                                            Thread.Sleep(1350);
                                        }
                                        else
                                        {
                                            Console.WriteLine("봉밀주가 부족합니다.");
                                            Thread.Sleep(1350);
                                        }
                                        break;

                                    case "4":
                                        Console.Clear();
                                        if (_attacker._mp10 >= 1)
                                        {
                                            _attacker._mp10 -= 1;
                                            _attacker._mana += 100;
                                            if (_attacker._mana >= _attacker._maxMana)
                                                _attacker._mana = _attacker._maxMana;
                                            Console.WriteLine("마나가 회복되었습니다.");
                                            Thread.Sleep(1350);
                                        }
                                        else
                                        {
                                            Console.WriteLine("봉밀주가 부족합니다.");
                                            Thread.Sleep(1350);
                                        }
                                        break;

                                    case "0":
                                        boolBag = false;
                                        break;
                                    default:
                                        break;
                                }

                            }
                            break;
                        ////////////////////
                        case "3": // 도망
                            if(runawayo == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("도망칩니다!");
                                Thread.Sleep(1356);
                                boolBT1 = false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("도망에 실패하였습니다.");
                                Thread.Sleep(1300);
                                MonsterFight(_target, _attacker);

                            }
                            break;
                        ////////////////////
                        default:
                            break;
                        ////////////////////
                    } // 스위치 엔드    
                    BattleResult(_attacker, _target);
                } // bt1 엔드
            } // 배틀메인 


            ///////////////////////////////////////
        } // Info End//////////////////////////////

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

                            _hp3 = 0;
                            _hp10 = 0;
                            _mp3 = 2;
                            _mp10 = 0;

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

                            _hp3 = 1;
                            _hp10 = 0;
                            _mp3 = 1;
                            _mp10 = 0;

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

                            _hp3 = 2;
                            _hp10 = 0;
                            _mp3 = 0;
                            _mp10 = 0;

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
            public void GoblinA()
            {
                _name = "고블린 전사";
                _opScript = "온 김에 먹히고 가라!!";
                _face = "[º益º]";
                _maxHp = 17;
                _hp = _maxHp;
                _str = 40; 
                _exp = 40;
                _gold = 520;
            }

            public void GoblinB()
            {
                _name = "고블린 아처";
                _opScript = "니 머리에 한 발~";
                _face = "[º益￠]";
                _maxHp = 17;
                _hp = _maxHp;
                _str = 8;
                _exp = 18;
                _gold = 680;
            }


        } // class Monster End
        static void Main(string[] args)
        {
            Info info = new Info();
            Player player = new Player();
            Monster mon = new Monster();

            int qc = 0;


            // 프롤로그 만들기~(스킵기능도)
            
            player.NickName();
            player.Job();
            Console.Clear();
            //Console.WriteLine($"어서오세요 {player._jobName} {player._name}님");
            info.PrintSct($"어서오세요 {player._jobName} {player._name}님");
            
            //Thread.Sleep(1200);

            while (true) //전체 while 
            {
                Console.Clear();
                Console.WriteLine("┌──────────────────────────┐");
                Console.WriteLine("│          내정보          │");
                Console.WriteLine("└──────────────────────────┘");
                Console.WriteLine($" [Lv.{player._level} {player._jobName} {player._name}]");
                Console.WriteLine($" ■경험치: {player._exp:F0}/{player._maxExp:F0}");
                Console.WriteLine($" ■목숨  : {player._life}");
                Console.WriteLine($" ■체력  : {player._hp:F0}/{player._maxHp:F0}");
                Console.WriteLine($" ■공격력: {player._str:F0}");
                Console.WriteLine($" ■마나  : {player._mana:F0}/{player._maxMana:F0}");
                Console.WriteLine($" ■골드  : {player._gold}");
                Console.WriteLine("┌──────────────────────────┐");
                Console.WriteLine("│        미드가르드        │");
                Console.WriteLine("├──────────────────────────┤");
                Console.WriteLine("│ 1.광장  2.상점  3.드워프 │");
                Console.WriteLine("│ 4.병원  5.모험  6.광산   │"); // 5.지역이동하는 이름
                Console.WriteLine("└──────────────────────────┘");
                //( 메뉴 재구성 해라
                string inputMenu = Console.ReadLine();
                switch(inputMenu)
                {
                    case "1"://광장 > 혹은 괜찮은 이름으로...
                        bool boolNpc = true;
                        while (boolNpc)
                        {
                            Console.Clear();
                            Console.WriteLine("[광장]");
                            if (qc == 0)
                                Console.WriteLine("1.(NEW)홍길동");
                            else if(qc == 1)
                                Console.WriteLine("1.(진행중)홍길동");
                            else if(qc >= 2)
                                Console.WriteLine("1. 홍길동");

                            Console.WriteLine("");
                            Console.WriteLine("0.뒤로가기");

                            string inputNpc = Console.ReadLine();
                            switch(inputNpc)
                            {
                                case "1":       //info.PrintSct("");
                                    if(qc == 0)
                                    {
                                        info.PrintSct("아무개 npc입니다.");
                                        info.PrintSct("이제 퀘스트를 시작합니다.");
                                        qc = 1;
                                    }

                                    else if(qc == 1)
                                    {
                                        info.PrintSct("진행중인 npc입니다.");
                                        info.PrintSct("지금은 퀘스트 진행중입니다.");
                                        qc = 2;
                                    }   
                                    
                                    else if(qc == 2)
                                    {
                                        Console.Clear();
                                        info.PrintSct("완료된 npc입니다.");
                                        info.PrintSct("이제 퀘스트가 완료되었습니다.");
                                        qc = 3;
                                    }
                                    break;
                                case "0":
                                    boolNpc = false;
                                    break;
                                default:
                                    break;

                            } // switch end

                        }
                        break;

                    case "2"://드워프
                        break;

                    case "3": // 
                        break;

                    case "4": //병원
                        break;

                    case "5": // 모험
                        bool boolDGmenu = true;
                        while (boolDGmenu)
                        {
                            Console.Clear();
                            Console.WriteLine("[원시림]");
                            if (qc >= 1)
                                Console.WriteLine("1.검은숲");
                            if(qc >= 3)
                                Console.WriteLine("2.아홉의 해안"); // 1스테이지 다 깨야 오픈
                            //Console.WriteLine("1. 밀림원");
                            //Console.WriteLine("2. 세계수"); // 밀림원에서 헤쳐나가야 나옴
                            Console.WriteLine("\n0. 뒤로가기");
                            /*Console.WriteLine("1. 알프하임");
                            Console.WriteLine("2. 요툰하임"); // 세계수 메뉴임
                            Console.WriteLine("3. 헬하임"); // 다 보이게 하고 못 들어가게만
                            Console.WriteLine("4. 아스가르드"); // 순서는 나중에 다시 재정비..
                            Console.WriteLine("0. 뒤로가기");
                            */
                            Console.WriteLine("");
                            string inputDungeon = Console.ReadLine();
                            switch (inputDungeon)
                            {
                                case "1":
                                    if (qc >= 1)
                                    {
                                        bool boolBF = true;
                                        while (boolBF)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("[검은숲]");
                                            Console.WriteLine("1. 몬스터1");
                                            Console.WriteLine("2. 몬스터2");
                                            Console.WriteLine("");
                                            Console.WriteLine("0.뒤로가기");

                                            string inputBF = Console.ReadLine();
                                            switch (inputBF)
                                            {
                                                case "1":
                                                    Console.Clear();
                                                    mon.GoblinA();
                                                    info.BattleMain(player, mon);
                                                    break;

                                                case "2":
                                                    Console.Clear();
                                                    mon.GoblinB();
                                                    info.BattleMain(player, mon);
                                                    break;

                                                case "0":
                                                    boolBF = false;
                                                    break;

                                                default:
                                                    break;
                                            }// switch end
                                        }
                                    }


                                    break;
                                case "2":
                                    if(qc >= 3)
                                    {
                                        bool boolNR = true;
                                        while(boolNR)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("[아홉의 해안]");
                                            Console.WriteLine("1. 몬스터3");
                                            Console.WriteLine("2. 몬스터4");
                                            Console.WriteLine("");
                                            Console.WriteLine("0.뒤로가기");

                                            string inputNR = Console.ReadLine();
                                            switch (inputNR)
                                            {
                                                case "1":
                                                    Console.Clear();
                                                    mon.GoblinA();
                                                    info.BattleMain(player, mon);
                                                    break;

                                                case "2":
                                                    Console.Clear();
                                                    mon.GoblinB();
                                                    info.BattleMain(player, mon);
                                                    break;

                                                case "0":
                                                    boolNR = false;
                                                    break;

                                                default:
                                                    break;
                                            }// switch end

                                        }
                                    }

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




