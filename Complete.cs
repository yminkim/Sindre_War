using System;
using System.Data.SqlTypes;
using System.Diagnostics;
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

            public int bossC; // 보스 번호
            public int skillC;
            public int Valkyrie;
            bool boolWskill = true;

            public string _Twp;
            public string _Tam;
            public string _Trg;

            public double _Rstr;
            public double _Rhp;
            public double _Rmana;
            public double _Tstr;
            public double _Tdef;
            public double _Tmana;

            public int weaponC = 0;
            public int armorC = 0;
            public int ringC = 0;


            public bool boolBT2;
            // 무기 방어구 스탯은 대기
            //////////////////////////////////////
            //////////////////////////////////////
            /////(장비종류번호, 이름, 증가값, 골드)
            //info.Weapon(plyaer, , "스톤해머", 5, 20000);
            public void Chawon()
            {
                Console.Clear();
                Console.WriteLine("차원 이동석을 사용합니다.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("이동중입니다.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("이동중입니다..");
                Thread.Sleep(1000);
            }
            public void MidGa()
            {
                Console.Clear();
                Console.WriteLine("차원 이동석을 사용합니다.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("미드가르드로 돌아갑니다.");
                Thread.Sleep(1000);
            }

            public void ValQ()
            {
                _name = "시그룬";
                _opScript = "오딘: 강림하라, 발키리의 여왕이여";
                _face = "◀θΠθ▶";
                _maxHp = 99;
                _hp = _maxHp;
                _str = 49;
                _exp = 0;
                _gold = 0;
                bossC = 0;
                Valkyrie = 1;
            }

            public void Val()
            {
                _name = "괸둘";
                _opScript = "오딘: 나를위해 싸우거라, 발키리여";
                _face = "─Θ∩Θ─";
                _maxHp = 87;
                _hp = _maxHp;
                _str = 31;
                _exp = 0;
                _gold = 0;
                bossC = 0;
                Valkyrie = 1;
            }


            public void Ring(Info _player, int rgC, string ringName, double plusMana, int goldx)
            {
                string ringTName = ringName;
                double ringPlusStr = plusMana;
                int spendGold = goldx;
                int CCC3 = rgC;

                if (_player._gold >= spendGold)
                {
                    _player._gold -= spendGold;
                    _player._Trg = ringTName;
                    _player._Tmana = ringPlusStr;
                    _player._Rmana = _player._Tmana + _player._maxMana;
                    Console.Clear();
                    Console.WriteLine("쾅!");
                    Thread.Sleep(800);
                    Console.WriteLine("     쾅!");
                    Thread.Sleep(800);
                    Console.WriteLine("          쾅!");
                    Thread.Sleep(800);
                    PrintSct("드워프 형제: 완성됐네!!");
                    _player.ringC = CCC3;
                }
                else
                {
                    PrintSct("금액이 부족하다네..!");
                }
            }
            public void Armor(Info _player, int amC, string armorName, double plusHp, int goldx)
            {
                string armorTName = armorName;
                double armorPlusStr = plusHp;
                int spendGold = goldx;
                int CCC2 = amC;

                if (_player._gold >= spendGold)
                {
                    _player._gold -= spendGold;
                    _player._Tam = armorTName;
                    _player._Tdef = armorPlusStr;
                    _player._Rhp = _player._Tdef + _player._maxHp;
                    Console.Clear();
                    Console.WriteLine("쾅!");
                    Thread.Sleep(800);
                    Console.WriteLine("     쾅!");
                    Thread.Sleep(800);
                    Console.WriteLine("          쾅!");
                    Thread.Sleep(800);
                    PrintSct("드워프 형제: 완성됐네!!");
                    _player.armorC = CCC2;
                }
                else
                {
                    PrintSct("금액이 부족하다네..!");
                }
            }
            public void Weapon(Info _player, int wpC, string weaponName, double plusStr, int goldx)
            {

                string weaponTName = weaponName;
                double weaponPlusStr = plusStr;
                int spendGold = goldx;
                int CCC = wpC;

                if (_player._gold >= spendGold)
                {
                    _player._gold -= spendGold;
                    _player._Twp = weaponTName;
                    _player._Tstr = weaponPlusStr;
                    _player._Rstr = _player._Tstr + _player._str;
                    Console.Clear();
                    Console.WriteLine("쾅!");
                    Thread.Sleep(800);
                    Console.WriteLine("     쾅!");
                    Thread.Sleep(800);
                    Console.WriteLine("          쾅!");
                    Thread.Sleep(800);
                    PrintSct("드워프 형제: 완성됐네!!");
                    _player.weaponC = CCC;
                }
                else
                {
                    PrintSct("금액이 부족하다네..!");
                }
            }
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
                Console.WriteLine($"◎체력   : {_attacker._hp:F0}/{_attacker._Rhp:F0}");
                Console.WriteLine($"◎공격력 : {_attacker._Rstr:F0}");
                Console.WriteLine($"◎마나   : {_attacker._mana:F0}/{_attacker._Rmana:F0}");
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
            public void BuyPotion(Info _player, int Money, int PtName)
            {
                int x = Money;
                int y = PtName;
                if (_player._gold >= x)
                {
                    if (y == 1)
                    {
                        _player._gold -= x;
                        _player._hp3 += 1;
                    }
                    else if (y == 2)
                    {
                        _player._gold -= x;
                        _player._hp10 += 1;
                    }
                    else if (y == 3)
                    {
                        _player._gold -= x;
                        _player._mp3 += 1;
                    }
                    else if (y == 4)
                    {
                        _player._gold -= x;
                        _player._mp10 += 1;
                    }
                    PrintSct("구매해줘서 고맙네!");
                }

                else
                {
                    Console.Clear();
                    PrintSct("돈이...부족하구나..");
                }

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
                    _target._hp -= (_attacker._Rstr * y);

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
                while (boolWskill)
                {
                    skillC = 0;
                    Console.Clear();
                    Console.WriteLine("[MP]");
                    Console.WriteLine($"마나: {_attacker._mana:F0}/{_attacker._Rmana:F0}\n");
                    Console.WriteLine("[스킬]");
                    if (_attacker._jobName == "전사")
                    {
                        Console.WriteLine("1.폭풍칼날(마나소모:15 / 140%)");  // 스킬명 마나소모량 딜량  표기 
                        Console.WriteLine("2.격노의 베기(마나소모:25 / 180%)");
                        Console.WriteLine("3.스파르탄의 분노(마나소모:35 / 230%)");
                    }
                    if (_attacker._jobName == "도적")
                    {
                        Console.WriteLine("1.그림자 밟기(마나소모:10 / 130%)");
                        Console.WriteLine("2.어둠의 칼날(마나소모:20 / 160%)");
                        Console.WriteLine("3.나이트메어(마나소모:30 / 200%)");
                    }
                    if (_attacker._jobName == "마법사")
                    {
                        Console.WriteLine("1.화염구(마나소모:20 / 150%)");
                        Console.WriteLine("2.도솔(마나소모:30 / 200%)");
                        Console.WriteLine("3.볼케이노(마나소모:50 / 300%)");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("0.뒤로가기");

                    string inputSkillW = Console.ReadLine();
                    switch (inputSkillW)
                    {
                        case "1":  //  SkillAttack(_a / _t / 대미지 / 마나 / 대사)
                            if (_attacker._jobName == "전사")
                                SkillAttack(_attacker, _target, 1.4, 15, "연속으로 적을 벱니다.");
                            if (_attacker._jobName == "도적")
                                SkillAttack(_attacker, _target, 1.8, 25, "적의 그림자를 공격합니다.");
                            if (_attacker._jobName == "마법사")
                                SkillAttack(_attacker, _target, 2.3, 35, "화염구를 던집니다.");
                            break;

                        case "2":
                            if (_attacker._jobName == "전사")
                                SkillAttack(_attacker, _target, 1.3, 25, "힘을 최대로 모아 적을 공격합니다.");
                            if (_attacker._jobName == "도적")
                                SkillAttack(_attacker, _target, 1.6, 20, "어둠에 숨어 적을 공격합니다.");
                            if (_attacker._jobName == "마법사")
                                SkillAttack(_attacker, _target, 2.0, 30, "칼바람을 강하게 불러일으킵니다.");
                            break;

                        case "3":
                            if (_attacker._jobName == "전사")
                                SkillAttack(_attacker, _target, 1.5, 35, "분노가 폭발합니다!!");
                            if (_attacker._jobName == "도적")
                                SkillAttack(_attacker, _target, 2.0, 30, "적의 정신을 조종합니다.");
                            if (_attacker._jobName == "마법사")
                                SkillAttack(_attacker, _target, 3.0, 50, "적에게 운석을 떨어트립니다.");
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
                    _target._hp = _target._hp - (_attacker._Rstr * 1.2);
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
                    _target._hp -= _attacker._Rstr;
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
            public void BossSkill(Info _attacker, Info _target, double mDmg)
            {
                double x = mDmg;
                _target._hp -= (_attacker._str * x);
            }

            public void BossAttack(Info _attacker, Info _target, Info _valQry)
            {
                Random ranStr = new Random();
                int rStr = ranStr.Next(1, 10);
                if (_attacker.bossC == 1) // 고블린킹
                {
                    if (rStr >= 1 && rStr <= 3) // 치뎀
                    {
                        BossSkill(_attacker, _target, 1.35);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "이 거대한 바위를 던집니다.(135%)");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }

                    else if (rStr >= 4 && rStr <= 7)
                    {
                        BossSkill(_attacker, _target, 1);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "이 강하게 공격합니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }

                    else if (rStr >= 8 && rStr <= 9)
                    {
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "이 지쳐 공격하지 못합니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    if (_target._hp <= 0)
                    {
                        if (_target._life >= 1)
                        {
                            _target._life -= 1;
                            _target._hp = _target._Rhp;
                        }
                    }

                } // goblin king end

                /////////////////////////////////////////
                if (_attacker.bossC == 2) // 엘프킹
                {
                    if (rStr >= 1 && rStr <= 3) // 치뎀
                    {
                        BossSkill(_attacker, _target, 1.6);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 빛을 폭발시킵니다.(160%)");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }

                    else if (rStr >= 4 && rStr <= 6)
                    {
                        BossSkill(_attacker, _target, 1);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 공격해옵니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }

                    else if (rStr >= 7 && rStr <= 9)
                    {
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 빛을 흡수합니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "의 체력이 15% 회복됩니다.");
                        Thread.Sleep(1350);
                        Console.Clear();
                        _attacker._hp += (_attacker._maxHp * 0.15);
                        if (_attacker._hp >= _attacker._maxHp)
                            _attacker._hp = _attacker._maxHp;

                    }
                    if (_target._hp <= 0)
                    {
                        if (_target._life >= 1)
                        {
                            _target._life -= 1;
                            _target._hp = _target._Rhp;
                        }
                    }

                } // 엘프킹

                /////////////////////////////////////////
                if (_attacker.bossC == 3) // 티르
                {
                    if (rStr >= 1 && rStr <= 2) // 치뎀
                    {
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 혼을 빼앗가 갑니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("목숨이 1 감소합니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        _target._life -= 1;

                    }

                    else if (rStr >= 3 && rStr <= 5)
                    {
                        BossSkill(_attacker, _target, 1);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 공격해옵니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }

                    else if (rStr >= 6 && rStr <= 7)
                    {
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 망령을 끌어모읍니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "의 체력이 9% 회복됩니다.");
                        Thread.Sleep(1350);
                        Console.Clear();
                        _attacker._hp += (_attacker._maxHp * 0.09);
                        if (_attacker._hp >= _attacker._maxHp)
                            _attacker._hp = _attacker._maxHp;

                    }
                    else if (rStr >= 8 && rStr <= 9)
                    {
                        Console.Clear();
                        Console.WriteLine("수 많은 망령이 티르의 몸을 통과합니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "의 체력이 5% 회복/증가됩니다.");
                        Thread.Sleep(1350);
                        Console.Clear();
                        _attacker._maxHp *= 1.05;
                        _attacker._hp += (_attacker._maxHp * 0.05);
                        if (_attacker._hp >= _attacker._maxHp)
                            _attacker._hp = _attacker._maxHp;

                    }
                    if (_target._hp <= 0)
                    {
                        if (_target._life >= 1)
                        {
                            _target._life -= 1;
                            _target._hp = _target._Rhp;
                        }
                    }

                } // 티르

                /////////////////////////////////////////
                if (_attacker.bossC == 4) // 토르
                {
                    if (rStr >= 1 && rStr <= 2) // 치뎀
                    {
                        BossSkill(_attacker, _target, 2.99);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 거대한 낙뢰를 떨굽니다.(299%)");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }

                    else if (rStr >= 3 && rStr <= 5)
                    {
                        BossSkill(_attacker, _target, 1);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 공격해옵니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }

                    else if (rStr >= 6 && rStr <= 7)
                    {
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 강한 전파를 내뿜습니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("2턴간 마비상태가 됩니다.");
                        Thread.Sleep(1350);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 공격해옵니다.");
                        Thread.Sleep(1200);
                        BossSkill(_attacker, _target, 1);
                        if (_target._hp <= 0)
                        {
                            _target._life -= 1;
                            _target._hp = _target._Rhp;
                        }
                        Console.Clear();
                        BattleInfo(_target, _attacker);
                        Thread.Sleep(1200);
                        BossSkill(_attacker, _target, 1);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "가 공격해옵니다.");
                        Thread.Sleep(1200);
                        Console.Clear();



                    }
                    else if (rStr >= 8 && rStr <= 9)
                    {
                        Console.Clear();
                        Console.WriteLine("토르가 자신의 몸에 낙뢰를 떨굽니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "의 체력이 6% 회복/증가됩니다.");
                        Thread.Sleep(1350);
                        Console.Clear();
                        _attacker._maxHp *= 1.06;
                        _attacker._hp += (_attacker._maxHp * 0.06);
                        if (_attacker._hp >= _attacker._maxHp)
                            _attacker._hp = _attacker._maxHp;

                    }
                    if (_target._hp <= 0)
                    {
                        if (_target._life >= 1)
                        {
                            _target._life -= 1;
                            _target._hp = _target._Rhp;
                        }
                    }

                } // 토르

                /////////////////////////////////////////
                if (_attacker.bossC == 5) // 최강신 오딘
                {
                    if (rStr >= 1 && rStr <= 2) // 일반 발키리 소환
                    {
                        _valQry.Val();
                        BattleMain2(_target, _valQry);
                    }

                    else if (rStr >= 3 && rStr <= 5)
                    {
                        _valQry.ValQ();
                        BattleMain2(_target, _valQry);
                    }

                    else if (rStr >= 6 && rStr <= 7)
                    {
                        BossSkill(_attacker, _target, 9.99);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "의 궁니르가 강하게 날라옵니다.(999%)");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else if (rStr >= 8 && rStr <= 9)
                    {
                        Console.Clear();
                        Console.WriteLine("오딘이 이둔의 황금사과를 먹습니다.");
                        Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine(_attacker._name + "의 체력이 3% 회복/증가됩니다.");
                        Thread.Sleep(1350);
                        Console.Clear();
                        _attacker._maxHp *= 1.03;
                        _attacker._hp += (_attacker._maxHp * 0.03);
                        if (_attacker._hp >= _attacker._maxHp)
                            _attacker._hp = _attacker._maxHp;

                    }
                    if (_target._hp <= 0)
                    {
                        if (_target._life >= 1)
                        {
                            _target._life -= 1;
                            _target._hp = _target._Rhp;
                        }
                    }

                } // 최강신 오딘

            } // boss attack end

            public void MonsterFight(Info _attacker, Info _target)
            {
                Random ranStr = new Random();
                int rStr = ranStr.Next(1, 10);
                if (rStr == 1) // 치뎀
                {
                    _target._hp -= (_attacker._str * 1.3);
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
                        _target._hp = _target._Rhp;
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
                if (_attatcker._level <= 9)
                {
                    Console.Clear();
                    Console.WriteLine("LEVEL UP!!");
                    Thread.Sleep(1400);

                    Console.Clear();
                    Console.WriteLine("[스탯 증가]");
                    Console.WriteLine($"◈레벨  : {_attatcker._level} ▶ {_attatcker._level + 1}");
                    Console.WriteLine($"◈경험치: {_attatcker._maxExp:F0} ▶ {_attatcker._maxExp + 50:F0}");
                    Console.WriteLine($"◈체력  : {_attatcker._maxHp:F0} ▶ {_attatcker._maxHp * 1.2:F0}");
                    Console.WriteLine($"◈공격력: {_attatcker._str:F0} ▶ {_attatcker._str * 1.2:F0}");
                    Console.WriteLine($"◈마나  : {_attatcker._maxMana:F0} ▶ {_attatcker._maxMana * 1.2:F0}");

                    Console.WriteLine("\n0. 확인");


                    _attatcker._exp = 0;
                    _attatcker._maxExp += 50;
                    _attatcker._level += 1;

                    _attatcker._maxHp *= 1.2;
                    double maxHHp = _attatcker._maxHp + _attatcker._Tdef;
                    _attatcker._Rhp = _attatcker._Tdef + _attatcker._maxHp;
                    _attatcker._hp = maxHHp;

                    _attatcker._maxMana *= 1.2;
                    double maxMMp = _attatcker._maxMana + _attatcker._Tmana;
                    _attatcker._Rmana = _attatcker._Tmana + _attatcker._maxMana;
                    _attatcker._mana = maxMMp;

                    _attatcker._str *= 1.2;
                    _attatcker._Rstr = _attatcker._Tstr + _attatcker._str;
                    Console.ReadLine();
                    if (_attatcker._level == 10)
                    {
                        Console.Clear();
                        Console.WriteLine("만렙을 달성하여 \n더이상 레벨이 오르지 않습니다.");
                        Console.ReadLine();
                    }


                }


            }
            /////////////////////////////////////////
            public void BattleResult(Info _attatcker, Info _target)
            {
                if (_attatcker._life == 0)
                {
                    _attatcker._life = 1;
                    _attatcker._hp = _attatcker._Rhp * 0.1;
                    Console.Clear();
                    Console.WriteLine("사망하셨습니다.");
                    Thread.Sleep(1400);
                    boolBT1 = false;
                }

                if (_target._hp <= 0)
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
            /// <summary>
            /// 
            /// </summary>
            /// <param name="_attatcker"></param>
            /// <param name="_target"></param>
            public void BattleResult2(Info _attatcker, Info _target2)
            {
                if (_attatcker._life == 0)
                {
                    _attatcker._life = 1;
                    _attatcker._hp = _attatcker._Rhp * 0.1;
                    Console.Clear();
                    Console.WriteLine("사망하셨습니다.");
                    Thread.Sleep(1400);
                    boolBT2 = false;
                    boolBT1 = false;
                }

                if (_target2._hp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("오딘: 감히!!");
                    Thread.Sleep(1400);

                    boolBT2 = false;
                }

            }// bresult end

            public void BattleMain(Info _attacker, Info _target, Info _valQry)
            {
                PrintSct($"{_target._opScript}");
                boolBT1 = true;
                while (boolBT1)
                {
                    Random runaway = new Random();
                    int runawayo = runaway.Next(1, 6);
                    Console.Clear();
                    BattleInfo(_attacker, _target);
                    BattleMenu();

                    string inputBattleMenu = Console.ReadLine();
                    switch (inputBattleMenu)
                    {
                        ////////////////////
                        case "1": // 전투
                            bool boolFight1 = true;
                            while (boolFight1)
                            {
                                Console.Clear();
                                Console.WriteLine("[전투]");
                                Console.WriteLine("1.평타");
                                Console.WriteLine("2.스킬");
                                Console.WriteLine("");
                                Console.WriteLine("0.뒤로가기");

                                string inputHowFight = Console.ReadLine();
                                switch (inputHowFight)
                                {
                                    case "1": //평타 << 아직 전투 테스트 안함tc만들고 ㄱㄱ
                                        PlayerFight(_attacker, _target);
                                        BattleInfo(_attacker, _target);
                                        Thread.Sleep(1300);
                                        if (_target._hp <= 0)
                                            boolFight1 = false;
                                        else
                                        {
                                            if (_target.bossC >= 1)
                                                BossAttack(_target, _attacker, _valQry);
                                            else
                                                MonsterFight(_target, _attacker);
                                        }
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
                                            {
                                                if (_target.bossC >= 1)
                                                    BossAttack(_target, _attacker, _valQry);
                                                else
                                                    MonsterFight(_target, _attacker);
                                            }
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
                            while (boolBag)
                            {
                                Console.Clear();
                                Console.WriteLine("[HP & MP]");
                                Console.WriteLine($"체력: {_attacker._hp:F0}/{_attacker._Rhp:F0}");
                                Console.WriteLine($"마나: {_attacker._mana:F0}/{_attacker._Rmana:F0}");
                                Console.WriteLine("");
                                Console.WriteLine("[가방]");
                                Console.WriteLine($"1.이둔의 사과(+30HP)[{_attacker._hp3}]");
                                Console.WriteLine($"2.이둔의 황금사과(+100HP)[{_attacker._hp10}]");
                                Console.WriteLine($"3.봉밀주(+30MP)[{_attacker._mp3}]");
                                Console.WriteLine($"4.핏빛 봉밀주(+100MP)[{_attacker._mp10}]");
                                Console.WriteLine("");
                                Console.WriteLine("0.뒤로가기");

                                string inputBag = Console.ReadLine();
                                switch (inputBag)
                                {
                                    case "1":
                                        Console.Clear();
                                        if (_attacker._hp3 >= 1)
                                        {
                                            _attacker._hp3 -= 1;
                                            _attacker._hp += 30;
                                            if (_attacker._hp >= _attacker._Rhp)
                                                _attacker._hp = _attacker._Rhp;
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
                                            if (_attacker._hp >= _attacker._Rhp)
                                                _attacker._hp = _attacker._Rhp;
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
                                            if (_attacker._mana >= _attacker._Rmana)
                                                _attacker._mana = _attacker._Rmana;
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
                                            if (_attacker._mana >= _attacker._Rmana)
                                                _attacker._mana = _attacker._Rmana;
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

                            if (runawayo == 1)
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
            ///
            public void BattleMain2(Info _attacker, Info _target2)
            {
                PrintSct($"{_target2._opScript}");
                boolBT2 = true;
                while (boolBT2)
                {
                    Console.Clear();
                    BattleInfo(_attacker, _target2);
                    BattleMenu();

                    string inputBattleMenu = Console.ReadLine();
                    switch (inputBattleMenu)
                    {
                        ////////////////////
                        case "1": // 전투
                            bool boolFight2 = true;
                            while (boolFight2)
                            {
                                Console.Clear();
                                Console.WriteLine("[전투]");
                                Console.WriteLine("1.평타");
                                Console.WriteLine("2.스킬");
                                Console.WriteLine("");
                                Console.WriteLine("0.뒤로가기");

                                string inputHowFight = Console.ReadLine();
                                switch (inputHowFight)
                                {
                                    case "1":
                                        PlayerFight(_attacker, _target2);
                                        BattleInfo(_attacker, _target2);
                                        Thread.Sleep(1300);

                                        if (_target2._hp >= 1)
                                            MonsterFight(_target2, _attacker);

                                        boolFight2 = false;

                                        break;
                                    ////////////////////
                                    case "2": //스킬
                                        Wskill(_attacker, _target2);
                                        if (skillC == 1)
                                        {
                                            BattleInfo(_attacker, _target2);
                                            Thread.Sleep(1300);

                                            if (_target2._hp >= 1)
                                                MonsterFight(_target2, _attacker);

                                            boolFight2 = false;
                                        }
                                        break;
                                    ////////////////////
                                    case "0":
                                        boolFight2 = false;
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
                            bool boolBag2 = true; // 불백?ㅋㅋㅋㅋ
                            while (boolBag2)
                            {
                                Console.Clear();
                                Console.WriteLine("[HP & MP]");
                                Console.WriteLine($"체력: {_attacker._hp:F0}/{_attacker._Rhp:F0}");
                                Console.WriteLine($"마나: {_attacker._mana:F0}/{_attacker._Rmana:F0}");
                                Console.WriteLine("");
                                Console.WriteLine("[가방]");
                                Console.WriteLine($"1.이둔의 사과(+30HP)[{_attacker._hp3}]");
                                Console.WriteLine($"2.이둔의 황금사과(+100HP)[{_attacker._hp10}]");
                                Console.WriteLine($"3.봉밀주(+30MP)[{_attacker._mp3}]");
                                Console.WriteLine($"4.핏빛 봉밀주(+100MP)[{_attacker._mp10}]");
                                Console.WriteLine("");
                                Console.WriteLine("0.뒤로가기");

                                string inputBag = Console.ReadLine();
                                switch (inputBag)
                                {
                                    case "1":
                                        Console.Clear();
                                        if (_attacker._hp3 >= 1)
                                        {
                                            _attacker._hp3 -= 1;
                                            _attacker._hp += 30;
                                            if (_attacker._hp >= _attacker._Rhp)
                                                _attacker._hp = _attacker._Rhp;
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
                                            if (_attacker._hp >= _attacker._Rhp)
                                                _attacker._hp = _attacker._Rhp;
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
                                            if (_attacker._mana >= _attacker._Rmana)
                                                _attacker._mana = _attacker._Rmana;
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
                                            if (_attacker._mana >= _attacker._Rmana)
                                                _attacker._mana = _attacker._Rmana;
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
                                        boolBag2 = false;
                                        break;
                                    default:
                                        break;
                                }

                            }
                            break;
                        ////////////////////
                        case "3": // 도망

                            Console.Clear();
                            Console.WriteLine("해당 전투에서는 도망칠 수 없습니다.");
                            Thread.Sleep(1300);


                            break;
                        ////////////////////
                        default:
                            break;
                            ////////////////////
                    } // 스위치 엔드    
                    BattleResult2(_attacker, _target2);
                } // bt1 엔드

            } // 배틀메인 


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
                    Console.WriteLine("│①전사  : 체력 75 | 공격력 9 | 마나 40│");
                    Console.WriteLine("│②도적  : 체력 60 | 공격력 9 | 마나 50│");
                    Console.WriteLine("│③마법사: 체력 50 | 공격력 9 | 마나 60│");
                    Console.WriteLine("└──────────────────────────────────────┘");
                    Console.WriteLine("");

                    string inputJob = Console.ReadLine();
                    switch (inputJob)
                    {
                        case "1":
                            _jobName = "전사";
                            _face = "(`ㅂ’)";
                            _life = 2;
                            _level = 1;

                            _Tdef = 0;
                            _Tmana = 0;

                            _maxHp = 75;
                            _Rhp = _maxHp + _Tdef;
                            _hp = _Rhp;
                            _str = 9;
                            _maxExp = 100;
                            _exp = 0;
                            _maxMana = 40;
                            _Rmana = _maxMana + _Tmana;
                            _mana = _Rmana;
                            _gold = 10000;

                            _hp3 = 0;
                            _hp10 = 0;
                            _mp3 = 2;
                            _mp10 = 0;

                            _Twp = "청동검";
                            _Tam = "나무방패";
                            _Trg = "황동반지";
                            _Tstr = 0;

                            _Rstr = _str + _Tstr;

                            weaponC = 0;
                            armorC = 0;
                            ringC = 0;

                            ChooseJob = false;
                            break;

                        case "2":
                            _jobName = "도적";
                            _face = "눈_눈";
                            _life = 2;
                            _level = 1;
                            _Tdef = 0;
                            _Tmana = 0;

                            _maxHp = 60;
                            _Rhp = _maxHp + _Tdef;
                            _hp = _Rhp;
                            _str = 9;
                            _maxExp = 100;
                            _exp = 0;
                            _maxMana = 50;
                            _Rmana = _maxMana + _Tmana;
                            _mana = _Rmana;
                            _gold = 10000;

                            _hp3 = 1;
                            _hp10 = 0;
                            _mp3 = 1;
                            _mp10 = 0;

                            _Twp = "수리검";
                            _Tam = "가죽옷";
                            _Trg = "황동반지";
                            _Tstr = 0;

                            _Rstr = _str + _Tstr;
                            weaponC = 0;
                            armorC = 0;
                            ringC = 0;

                            ChooseJob = false;
                            break;
                        case "3":
                            _jobName = "마법사";
                            _face = "±∇±";
                            _life = 2;
                            _level = 1;
                            _Tdef = 0;
                            _Tmana = 0;

                            _maxHp = 50;
                            _Rhp = _maxHp + _Tdef;
                            _hp = _Rhp;
                            _str = 9;
                            _maxExp = 100;
                            _exp = 0;
                            _maxMana = 60;
                            _Rmana = _maxMana + _Tmana;
                            _mana = _Rmana;
                            _gold = 10000;

                            _hp3 = 2;
                            _hp10 = 0;
                            _mp3 = 0;
                            _mp10 = 0;

                            _Twp = "수정구";
                            _Tam = "빨간망토";
                            _Trg = "황동반지";
                            _Tstr = 0;

                            _Rstr = _str + _Tstr;
                            weaponC = 0;
                            armorC = 0;
                            ringC = 0;

                            ChooseJob = false;
                            break;

                        default:
                            break;

                    } // switch end
                } //while end
            } // Job() End



        } // class Player End

        public class Monster : Info
        {
            public void Goblin1()
            {
                _name = "고블린 전사";
                _opScript = "입구를 지키는 고블린이다...";
                _face = "[Θ益Θ]";
                _maxHp = 24;
                _hp = _maxHp;
                _str = 8;
                _exp = 26;
                _gold = 1450;
                bossC = 0;
            }

            public void Goblin2()
            {
                _name = "고블린 아처";
                _opScript = "아처: 니 머리에 한 발~";
                _face = "[Φ益Φ]";
                _maxHp = 29;
                _hp = _maxHp;
                _str = 8;
                _exp = 34;
                _gold = 2100;
                bossC = 0;
            }
            public void Goblin3()
            {
                _name = "고블린 울프";
                _opScript = "엄니가 큰 고블린이다...";
                _face = "[￠益￠]";
                _maxHp = 34;
                _hp = _maxHp;
                _str = 9;
                _exp = 43;
                _gold = 2700;
                bossC = 0;
            }

            public void Goblin4()
            {
                _name = "고블린 사제";
                _opScript = "마력이 느껴지는 고블린이다..!";
                _face = "[±益±]";
                _maxHp = 52;
                _hp = _maxHp;
                _str = 12;
                _exp = 43;
                _gold = 3300;
                bossC = 0;
            }

            public void Goblin5()
            {
                _name = "고블린 킹";
                _opScript = "압도적인 크기다..!!!!";
                _face = "[￠益⊙]";
                _maxHp = 127;
                _hp = _maxHp;
                _str = 21;
                _exp = 61;
                _gold = 5000;
                bossC = 1; // 보스 번호
            }

            public void Elf1()
            {
                _name = "다크엘프";
                _opScript = "정말 검은엘프가 알프하임에....";
                _face = "{⊙∵⊙}";
                _maxHp = 64;
                _hp = _maxHp;
                _str = 29;
                _exp = 87;
                _gold = 4850;
                bossC = 0;
            }
            public void Elf2()
            {
                _name = "타락한 엘프";
                _opScript = "다크엘프와의 전쟁에서 패했나보군...";
                _face = "{♀┼♀}";
                _maxHp = 77;
                _hp = _maxHp;
                _str = 35;
                _exp = 99;
                _gold = 6780;
                bossC = 0;
            }
            public void Elf3()
            {
                _name = "스바르트알야우푸르";
                _opScript = "다크엘프들의 왕이다..!!!!!";
                _face = "∃㉧益⊙∈";
                _maxHp = 214;
                _hp = _maxHp;
                _str = 44;
                _exp = 129;
                _gold = 15000;
                bossC = 2;
            }

            public void Ghost1()
            {
                _name = "망령";
                _opScript = "죽은자의 망령이다...";
                _face = "♀Д♀";
                _maxHp = 110;
                _hp = _maxHp;
                _str = 41;
                _exp = 123;
                _gold = 9900;
                bossC = 0;
            }

            public void Tyr()
            {
                _name = "티르";
                _opScript = "전쟁의 신, 티르!!!\n결국 전투는 피할 수 없겠군";
                _face = "車▲車";
                _maxHp = 250;
                _hp = _maxHp;
                _str = 67;
                _exp = 277;
                _gold = 25000;
                bossC = 3;
            }
            public void Thor()
            {
                _name = "토르";
                _opScript = "덤비거라, 토르여!!";
                _face = "Ж合Ж";
                _maxHp = 306;
                _hp = _maxHp;
                _str = 77;
                _exp = 344;
                _gold = 18800;
                bossC = 4;
            }
            public void Heimdal()
            {
                _name = "헤임달";
                _opScript = "아스가르드의 수문장이군";
                _face = "º`合º";
                _maxHp = 211;
                _hp = _maxHp;
                _str = 59;
                _exp = 151;
                _gold = 18800;
                bossC = 0;
            }

            public void God()
            {
                _name = "오딘";
                _opScript = "그저 죽는 것만으로는 끝나지 않을 것이다.\n네 영혼마저 안식할 곳은 \n이그드라실 그 어디에도 없을 것이다.";
                _face = "■益㈇";
                _maxHp = 399;
                _hp = _maxHp;
                _str = 89;
                _exp = 999;
                _gold = 99999;
                bossC = 5;
            }



        } // class Monster End
        static void Main(string[] args)
        {
            Info info = new Info();
            Player player = new Player();
            Monster mon = new Monster();
            Monster mon2 = new Monster();

            int qc = 0; // Quest Count
            int mc = 0; // Monster Count
            int stone = 0;
            int pick = 0;

            int hellheimCount = 0;
            int yotoonheimCount = 0;
            int ASGDCount = 0;
            int firstYotoon = 1;

            int coupon = 1;
            // 프롤로그 만들기~(스킵기능도)
            ////////////////////////////////////////////////////////////////
            bool boolProlog = true;
            while (boolProlog)
            {
                Console.Clear();
                Console.WriteLine("[프롤로그]");
                Console.WriteLine("1.진행");
                Console.WriteLine("2.스킵");
                string inputSkip = Console.ReadLine();
                switch (inputSkip)
                {
                    case "1":
                        info.PrintSct("어머니께선 가끔 나의 증조부 크레파스에 대한 이야기를 해주셨다.");
                        info.PrintSct("증조부는 다른 세상의 신들을 모두 죽이시고 이 땅에 오셨다고 한다.");
                        info.PrintSct("그리고 왜때문인지 토르의 아들 마그니와 모디를 죽이셨고, 오딘과의 전쟁을 벌이셨다.");
                        info.PrintSct("하지만 그 끝은 좋지 않았고, 조부 아르테우스만을 남기시고 돌아가셨다.");
                        info.PrintSct("아르테우스는 증조부와 달리 전쟁보단 평화를 원하셨다.");
                        info.PrintSct("그래서 인간이셨던 드레를 만나 부친 '신 드레'를 낳으셨다.");
                        info.PrintSct("하지만 평화로운 나날도 오래가진 못했다.");
                        info.PrintSct("두 아들을 잃은 토르는 그 노여움을 아르테우스에게까지 끌고갔다.");
                        info.PrintSct("결국 아르테우스는 신 드레가 보는 눈 앞에서 돌아가셨다.");
                        info.PrintSct("신 드레는 복수심에 증조부의 길을 걷기로 했다.");
                        info.PrintSct("그렇게 아버지는 다시 오딘과의 전쟁을 벌이셨다.");
                        info.PrintSct("하지만 신들은 너무 강해 필적할 수 없었고, 마녀인 어머니를 만나 그의 힘과 지식, 마력까지 나에게 물려주시고 돌아가셨다.");
                        info.PrintSct("오딘은 3대에 걸쳐 신에게 대적했다는 것을 명분으로");
                        info.PrintSct("인간을 짐승만도 못한 취급을 받게하며 탄압과 학살을 당연시하게했다.");
                        info.PrintSct("결국 어머니까지 돌아가시게 되었고, 이 전쟁을 끝내야 하는 것은 피할 수 없는 운명이 되었다.");
                        info.PrintSct("그리고 이건 나의 아버지 신드레가 벌인 전쟁의 종지부를 찍는 이야기다.");
                        boolProlog = false;
                        break;
                    case "2":
                        boolProlog = false;
                        break;
                    default:
                        break;
                }
            }

            bool boolMain = true;
            while (boolMain)
            {
                Console.Clear();
                Console.WriteLine("   ■    ■    ■■■■     ■■■    ■ ■");
                Console.WriteLine("  ■ ■  ■    ■               ■    ■ ■");
                Console.WriteLine(" ■   ■ ■    ■■■■     ■■■  ■■ ■");
                Console.WriteLine("  ■                        ■        ■ ■");
                Console.WriteLine("  ■■■■    ■■■■■    ■■■    ■ ■");
                Console.WriteLine("      ");
                Console.WriteLine("    ■    ■    ■      ■        ■■■");
                Console.WriteLine("      ■■  ■■      ■  ■      ■ ■");
                Console.WriteLine("       ■    ■     ■      ■    ■   ■");
                Console.WriteLine("");
                Console.WriteLine("                [신드레 전쟁]");
                Console.WriteLine("                 1. 시작하기");

                string inputSkip = Console.ReadLine();
                switch (inputSkip)
                {
                    case "1":
                        boolMain = false;
                        break;

                    default:
                        break;
                }
            }

            ////////////////////////////////////////////////////////////////
            player.NickName();
            player.Job();
            Console.Clear();
            info.PrintSct($"어서오세요 {player._jobName} {player._name}님");

            while (true) //전체 while 
            {
                Console.Clear();
                Console.WriteLine("┌──────────────────────────┐");
                Console.WriteLine("│          내정보          │");
                Console.WriteLine("└──────────────────────────┘");
                Console.WriteLine($" [Lv.{player._level} {player._jobName} {player._name}]");
                Console.WriteLine($" ■목숨  : {player._life}");
                Console.WriteLine($" ■체력  : {player._hp:F0}/{player._Rhp:F0}");
                Console.WriteLine($" ■공격력: {player._Rstr:F0}");
                Console.WriteLine($" ■마나  : {player._mana:F0}/{player._Rmana:F0}");
                Console.WriteLine($" ■경험치: {player._exp:F0}/{player._maxExp:F0}");
                Console.WriteLine($" ■골드  : {player._gold}");
                Console.WriteLine("┌──────────────────────────┐");
                Console.WriteLine("│        미드가르드        │");
                Console.WriteLine("├──────────────────────────┤");
                Console.WriteLine("│ 1.광장  2.애드  3.드워프 │");
                Console.WriteLine("│ 4.샘    5.모험  6.광산   │"); // 5.지역이동하는 이름
                Console.WriteLine("└──────────────────────────┘");
                //( 메뉴 재구성 해라
                string inputMenu = Console.ReadLine();
                switch (inputMenu)
                {
                    case "1"://광장 > 혹은 괜찮은 이름으로...
                        bool boolNpc = true;
                        while (boolNpc)
                        {
                            Console.Clear();
                            Console.WriteLine("[광장]");
                            if (qc == 0)
                                Console.WriteLine("1.(NEW)프레이야");
                            else if (qc == 1)
                                Console.WriteLine("1.(진행중)프레이야");
                            else if (qc == 2)
                                Console.WriteLine("1.(완료)프레이야");
                            else if (qc >= 3)
                                Console.WriteLine("1.프레이야");

                            Console.WriteLine("2.행인");
                            Console.WriteLine("");
                            Console.WriteLine("0.뒤로가기");

                            string inputNpc = Console.ReadLine();
                            switch (inputNpc)
                            {
                                case "1":       //info.PrintSct("");
                                    if (qc == 0)
                                    {
                                        info.PrintSct($"{player._name}, 드디어.. 여정을 떠나는 군아..");
                                        info.PrintSct("그들이 있는 곳으로 가려면 영역을 이동해야해.");
                                        info.PrintSct("영역이동은 검은숲에 있는 동굴을 지나\n아홉의 해안에 있는 신전에서 할 수 있는데,");
                                        info.PrintSct("너가 수련하는 10년간 그곳은 \n고블린들의 소굴이 되었어.");
                                        info.PrintSct("우선 고블린들을 소탕하고 이곳으로 돌아오렴.");
                                        qc = 1;
                                    }

                                    else if (qc == 1)
                                    {
                                        info.PrintSct("고블린은 뭐든 먹는 괴물이란다.\n조심하렴");
                                    }

                                    else if (qc == 2)
                                    {
                                        info.PrintSct("이제 신전으로 들어갈 수 있을거야.");
                                        info.PrintSct("오딘과 다른 신들은 아스가르드에 있어.");
                                        info.PrintSct("하지만 바로 아스가르드에 갈 수는 없어..");
                                        info.PrintSct("영역을 이동하려면 차원이동석이 필요한데,");
                                        info.PrintSct("아스가르드의 차원이동석은 어디있는지 몰라.");
                                        info.PrintSct("아마 다른 차원 어딘가에 있을거야.");
                                        info.PrintSct("강길을 따라 쭉 가면 신전이 있을거야");
                                        info.PrintSct("우선 알프하임을 탐사해보렴.");
                                        info.PrintSct("이 차원이동석이 필요할 거야...");
                                        Console.Clear();
                                        Console.WriteLine("'알프하임 차원이동석'을 획득하였습니다.");
                                        Thread.Sleep(1500);
                                        info.PrintSct("그럼 무운을 빌게..");
                                        qc = 3;
                                    }
                                    else if (qc == 3)
                                    {
                                        info.PrintSct("알프하임은 지금 엘프와 다크엘프가 전쟁중인 곳이야");
                                        info.PrintSct("그들은 강인한 전사들이지");
                                    }
                                    else if (qc == 4)
                                    {
                                        info.PrintSct($"무사히 돌아왔군아, {player._name}");
                                        info.PrintSct("헬헤임의 차원석이라....");
                                        info.PrintSct("헬헤임은 망자들의 세계야..");
                                        info.PrintSct("어찌보면 가장 위험할 수 있는 영역이야");
                                        info.PrintSct("과거 오딘과의 정면대결에서 패한 티르가\n있는 곳이기도 하거든");
                                        info.PrintSct("아마 차원석이 있을 \n가장 깊은 곳에 티르가 있을거야...");
                                        info.PrintSct("그는 많이 약해졌지만 그래도 한 때 전쟁의 신이었어");
                                        info.PrintSct("가급적이면 전투를 피하는 것이 좋아....");
                                        info.PrintSct("그럼 무운을 빌마....");
                                        qc = 5;
                                    }
                                    else if (qc == 5)
                                    {
                                        info.PrintSct($"무운을 빌게, {player._name}");
                                    }

                                    else if (qc == 6)
                                    {
                                        info.PrintSct($"무사히 돌아와 다행이야, {player._name}");
                                        info.PrintSct("요툰하임이라....");
                                        info.PrintSct("요툰하임은 거인족인 요트나르의 세계야.");
                                        info.PrintSct("하지만 거인은 없어");
                                        info.PrintSct("토르가 거인족들을 모두 죽였거든");
                                        info.PrintSct("토르는 거인족을 매우 싫어했어.");
                                        info.PrintSct("무튼 이번 여정은 그리 어렵지 않을거야");
                                        info.PrintSct($"무운을 빌게, {player._name}");
                                        qc = 7;
                                    }
                                    else if (qc == 7)
                                    {
                                        info.PrintSct($"빠샤빠샤, {player._name}");

                                    }
                                    else if (qc == 8)
                                    {
                                        info.PrintSct("설마 토르가 있을 줄이야...");
                                        info.PrintSct("게다가 토르까지 이길줄은 사실 몰랐어");
                                        info.PrintSct("이젠 아스가르드로 가는군아..");
                                        info.PrintSct("아스가르드는 이그드라실의 첫 번째 뿌리야");
                                        info.PrintSct("높은 하늘 속 구름속에 있지");
                                        info.PrintSct("신족이 사는 세계로 너가 토르를 죽인 시점에서\n지금은 오딘 밖에 없을거야.");
                                        info.PrintSct("오딘은 알다싶이 애시르 신족의 최고신이야.");
                                        info.PrintSct("마법과 지혜의 신이며, 전쟁의 신이지");
                                        info.PrintSct("오딘은 자신의 신전 발할라에서 안식을 취하고 있어");
                                        info.PrintSct("아무도 없다곤 해도 \n그의 수호병들은 오딘이 부리고 있을거야");
                                        info.PrintSct("힘든 싸움이 될거야.");
                                        info.PrintSct($"무운을 빌마, {player._name}");
                                        qc = 9;
                                    }
                                    else if (qc == 9)
                                    {
                                        info.PrintSct("만만의 준비를 하고 가렴...");
                                    }

                                    else if (qc == 10)
                                    {
                                        info.PrintSct("이젠 너의 삶을 찾아 떠나렴");
                                        info.PrintSct("넌 그럴 자격이 충분하단다.");
                                    }

                                    break;
                                case "2":       //info.PrintSct("");
                                    if (coupon == 1)
                                    {
                                        info.PrintSct("찾아와줘서 고맙네!");
                                        info.PrintSct("선물로 황금사과와 봉밀주를 하나씩 주겠네ㅎㅎ!");
                                        Console.Clear();
                                        Console.WriteLine("이둔의 황금사과x1\n핏빛 봉밀주x1\n를 획득하였습니다.");
                                        Thread.Sleep(1500);
                                        info.PrintSct("그럼 여정을 즐기시게!");
                                        player._hp10 = 1;
                                        player._mp10 = 1;
                                        coupon = 0;
                                    }
                                    else
                                    {
                                        info.PrintSct("화이팅 하시게");
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

                    case "2"://애드
                        Console.Clear();
                        info.PrintSct("안녕한가? 나는 이숲의 탐험가 애드라네\n사과와 술을 모으지");
                        bool boolAdd = true;
                        while (boolAdd)
                        {
                            Console.Clear();
                            Console.WriteLine("[애드의 상점]");
                            Console.WriteLine("무엇을 구매하겠는가?");
                            Console.WriteLine("");
                            Console.WriteLine($"▣보유금액:{player._gold}");
                            Console.WriteLine($"①2,900 - 이둔의 사과     (+30HP)[보유: {player._hp3}개]");
                            Console.WriteLine($"②8,900 - 이둔의 황금사과(+100HP)[보유: {player._hp10}개] ");
                            Console.WriteLine($"③3,000 - 봉밀주          (+30MP)[보유: {player._mp3}개]");
                            Console.WriteLine($"④9,900 - 핏빛 봉밀주    (+100MP)[보유: {player._mp10}개]");
                            Console.WriteLine($"\n⑤10,000 - 곡괭이 내구성+80(현내구성:{pick})");
                            Console.WriteLine("\n\n0.뒤로가기");
                            Console.WriteLine("");

                            string inputShop = Console.ReadLine();
                            switch (inputShop)
                            {
                                case "1":
                                    info.BuyPotion(player, 2900, 1);
                                    break;
                                case "2":
                                    info.BuyPotion(player, 8900, 2);
                                    break;
                                case "3":
                                    info.BuyPotion(player, 3000, 3);
                                    break;
                                case "4":
                                    info.BuyPotion(player, 9900, 4);
                                    break;
                                case "5":
                                    if (player._gold >= 10000)
                                    {
                                        player._gold -= 10000;
                                        pick += 80;
                                        Console.Clear();
                                        Console.WriteLine("고맙네!");
                                        Thread.Sleep(1300);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("금액이 부족하다네!!");
                                        Thread.Sleep(1200);
                                    }
                                    break;
                                case "0":
                                    boolAdd = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case "3": // 드워프
                        Console.Clear();
                        Console.WriteLine("브록&신드리: 우린 뭐든 만들지!");
                        Thread.Sleep(1400);
                        bool boolToolShop = true;
                        while (boolToolShop)
                        {
                            Console.Clear();
                            Console.WriteLine("[브록&신드리]");
                            Console.WriteLine("");
                            Console.WriteLine("────────────── 장비 ──────────────");
                            Console.WriteLine($"▣무기  :{player._Twp} - {player._str:F0}(+{player._Tstr})");
                            Console.WriteLine($"▣방어구:{player._Tam} - {player._maxHp:F0}(+{player._Tdef})");
                            Console.WriteLine($"▣반지  :{player._Trg} - {player._maxMana:F0}(+{player._Tmana})");
                            Console.WriteLine("──────────────────────────────────");
                            Console.WriteLine("[메뉴를 선택해주세요]");
                            Console.WriteLine("1.무기\n2.방어구\n3.반지\n\n4.강화");
                            Console.WriteLine("\n\n0.뒤로가기");

                            string inputToolMenu = Console.ReadLine();
                            switch (inputToolMenu)
                            {
                                /////////////////////////////////////////////////////////////////////////
                                case "1":
                                    bool boolTools = true;
                                    while (boolTools)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("────────────── 장비 ──────────────");
                                        Console.WriteLine($"▣무기  :{player._Twp} - {player._str:F0}(+{player._Tstr})");
                                        Console.WriteLine("──────────────────────────────────");
                                        Console.WriteLine($"무엇을 구매하겠는가? (보유금액: {player._gold})");
                                        if (player._jobName == "전사")
                                        {
                                            Console.WriteLine("1. 15,000 - 사인검(+3)");
                                            Console.WriteLine("2. 30,000 - 듀랜달(+6)");
                                            Console.WriteLine("3. 50,000 - 수르트의 검(+9)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        if (player._jobName == "도적")
                                        {
                                            Console.WriteLine("1. 15,000 - 단검(+3)");
                                            Console.WriteLine("2. 30,000 - 고대단검(+6)");
                                            Console.WriteLine("3. 50,000 - 카른웨난(+9)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        if (player._jobName == "마법사")
                                        {
                                            Console.WriteLine("1. 15,000 - 매직팡이(+3)");
                                            Console.WriteLine("2. 30,000 - 다그다의 곤봉(+6)");
                                            Console.WriteLine("3. 50,000 - 스퀴테(+9)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        string inputWeapon = Console.ReadLine();
                                        switch (inputWeapon)
                                        {
                                            case "1": //(이름, 증가값, 골드)
                                                if (player.weaponC == 0)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Weapon(player, 1, "사인검", 3, 15000);
                                                    if (player._jobName == "도적")
                                                        info.Weapon(player, 1, "단검", 3, 15000);
                                                    if (player._jobName == "마법사")
                                                        info.Weapon(player, 1, "매직팡이", 3, 15000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "2":
                                                if (player.weaponC == 0 || player.weaponC == 1)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Weapon(player, 2, "듀랜달", 6, 30000);
                                                    if (player._jobName == "도적")
                                                        info.Weapon(player, 2, "고대단검", 6, 30000);
                                                    if (player._jobName == "마법사")
                                                        info.Weapon(player, 2, "다그다의 곤봉", 6, 30000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "3":
                                                if (player.weaponC >= 0 && player.weaponC <= 2)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Weapon(player, 3, "수르트의 검", 9, 50000);
                                                    if (player._jobName == "도적")
                                                        info.Weapon(player, 3, "카른웨난", 9, 50000);
                                                    if (player._jobName == "마법사")
                                                        info.Weapon(player, 3, "스퀴테", 9, 50000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "0":
                                                boolTools = false;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                /////////////////////////////////////////////////////////////////////////
                                case "2":
                                    bool boolTools2 = true;
                                    while (boolTools2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("────────────── 장비 ──────────────");
                                        Console.WriteLine($"▣방어구:{player._Tam} - {player._maxHp:F0}(+{player._Tdef})");
                                        Console.WriteLine("──────────────────────────────────");
                                        Console.WriteLine($"무엇을 구매하겠는가? (보유금액: {player._gold})");
                                        if (player._jobName == "전사")
                                        {
                                            Console.WriteLine("1. 15,000 - 멧돼지 보호구(+15)");
                                            Console.WriteLine("2. 30,000 - 강철 아대(+30)");
                                            Console.WriteLine("3. 50,000 - 신드리의 갑옷(+60)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        if (player._jobName == "도적")
                                        {
                                            Console.WriteLine("1. 15,000 - 소뼈 투구(+15)");
                                            Console.WriteLine("2. 30,000 - 사슬 갑옷(+30)");
                                            Console.WriteLine("3. 50,000 - 발키리 흉갑(+60)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        if (player._jobName == "마법사")
                                        {
                                            Console.WriteLine("1. 15,000 - 마녀의 망토(+15)");
                                            Console.WriteLine("2. 30,000 - 브록의 망토(+30)");
                                            Console.WriteLine("3. 50,000 - 발키리 망토(+60)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        string inputWeapon = Console.ReadLine();
                                        switch (inputWeapon)
                                        {
                                            case "1": //(이름, 증가값, 골드)
                                                if (player.armorC == 0)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Armor(player, 1, "멧돼지 보호구", 15, 15000);
                                                    if (player._jobName == "도적")
                                                        info.Armor(player, 1, "소뼈 투구", 15, 15000);
                                                    if (player._jobName == "마법사")
                                                        info.Armor(player, 1, "마녀의 망토", 15, 15000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "2":
                                                if (player.armorC == 0 || player.armorC == 1)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Armor(player, 2, "강철 아대", 30, 30000);
                                                    if (player._jobName == "도적")
                                                        info.Armor(player, 2, "사슬 갑옷", 30, 30000);
                                                    if (player._jobName == "마법사")
                                                        info.Armor(player, 2, "브록의 망토", 30, 30000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "3":
                                                if (player.armorC >= 0 && player.armorC <= 2)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Armor(player, 3, "신드리의 갑옷", 60, 50000);
                                                    if (player._jobName == "도적")
                                                        info.Armor(player, 3, "발키리 흉갑", 60, 50000);
                                                    if (player._jobName == "마법사")
                                                        info.Armor(player, 3, "브록의 망토", 60, 50000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "0":
                                                boolTools2 = false;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;

                                /////////////////////////////////////////////////////////////////////////
                                case "3":
                                    bool boolTools3 = true;
                                    while (boolTools3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("────────────── 장비 ──────────────");
                                        Console.WriteLine($"▣반지:{player._Trg} - {player._maxMana:F0}(+{player._Tmana})");
                                        Console.WriteLine("──────────────────────────────────");
                                        Console.WriteLine($"무엇을 구매하겠는가? (보유금액: {player._gold})");
                                        if (player._jobName == "전사")
                                        {
                                            Console.WriteLine("1. 10,000 - 전의의 반지(+10)");
                                            Console.WriteLine("2. 25,000 - 전장의 반지(+20)");
                                            Console.WriteLine("3. 40,000 - 지배자의 반지(+35)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        if (player._jobName == "도적")
                                        {
                                            Console.WriteLine("1. 10,000 - 니들링(+10)");
                                            Console.WriteLine("2. 25,000 - 카우링(+20)");
                                            Console.WriteLine("3. 40,000 - 루핀링(+35)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        if (player._jobName == "마법사")
                                        {
                                            Console.WriteLine("1. 10,000 - 마녀의 반지(+10)");
                                            Console.WriteLine("2. 25,000 - 승리의 반지(+20)");
                                            Console.WriteLine("3. 40,000 - 여신의 반지(+35)");
                                            Console.WriteLine("\n0.뒤로가기");
                                        }
                                        string inputWeapon = Console.ReadLine();
                                        switch (inputWeapon)
                                        {
                                            case "1": //(이름, 증가값, 골드)
                                                if (player.ringC == 0)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Ring(player, 1, "전의의 반지", 10, 10000);
                                                    if (player._jobName == "도적")
                                                        info.Ring(player, 1, "니들링", 10, 10000);
                                                    if (player._jobName == "마법사")
                                                        info.Ring(player, 1, "마녀의 반지", 10, 10000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "2":
                                                if (player.ringC == 0 || player.ringC == 1)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Ring(player, 2, "전장의 반지", 20, 25000);
                                                    if (player._jobName == "도적")
                                                        info.Ring(player, 2, "카우링", 20, 25000);
                                                    if (player._jobName == "마법사")
                                                        info.Ring(player, 2, "승리의 반지", 20, 25000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "3":
                                                if (player.ringC >= 0 && player.ringC <= 2)
                                                {
                                                    if (player._jobName == "전사")
                                                        info.Ring(player, 3, "지배자의 반지", 35, 40000);
                                                    if (player._jobName == "도적")
                                                        info.Ring(player, 3, "루핀링", 35, 40000);
                                                    if (player._jobName == "마법사")
                                                        info.Ring(player, 3, "여신의 반지", 35, 40000);
                                                }
                                                else
                                                {
                                                    info.PrintSct("이미 샀거나, 등급이 낮아 구입할 수 없다네.");
                                                }
                                                break;
                                            case "0":
                                                boolTools3 = false;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;


                                /////////////////////////////////////////////////////////////////////////
                                case "4":
                                    bool bolTglow = true;
                                    while (bolTglow)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("────────────── 장비 ──────────────");
                                        Console.WriteLine($"▣무기  :{player._Twp} - {player._str:F0}(+{player._Tstr})");
                                        Console.WriteLine("──────────────────────────────────");
                                        Console.WriteLine("신드리: 참고로 무기를 새로 사면 강화는 0이 된다네....");
                                        Console.WriteLine($"강화 하십니까? (보유광석: {stone})");
                                        Console.WriteLine("1. 광석 30개 - 무기 1강화");
                                        Console.WriteLine("");
                                        Console.WriteLine("0.뒤로가기");

                                        string inputTglow = Console.ReadLine();
                                        switch (inputTglow)
                                        {
                                            case "1":
                                                if (stone >= 30)
                                                {
                                                    stone -= 30;
                                                    player._Tstr += 1;
                                                    player._Rstr = player._Tstr + player._str;
                                                    Console.Clear();
                                                    Console.WriteLine("강화되었네!");
                                                    Thread.Sleep(1400);
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("광석이 부족하네...!");
                                                    Thread.Sleep(1200);
                                                }
                                                break;
                                            case "0":
                                                bolTglow = false;
                                                break;
                                            default:
                                                break;
                                        }
                                    }

                                    break;

                                /////////////////////////////////////////////////////////////////////////

                                case "0":
                                    boolToolShop = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case "4": //샘
                        info.PrintSct("난 샘의 주인 포툴카\n성의에 따라 샘물을 제공하겠네");

                        Console.Clear();
                        bool boolSam = true;
                        while (boolSam)
                        {
                            Console.Clear();
                            Console.WriteLine("[생명의 샘]");
                            Console.WriteLine("");
                            Console.WriteLine($"*보유금액: {player._gold}");
                            Console.WriteLine("1.한모금   - 무료");
                            Console.WriteLine("2.완전회복 - 9,000골드");
                            Console.WriteLine("3.목숨 +1  - 40,000골드");
                            Console.WriteLine("");
                            Console.WriteLine("0.뒤로가기");

                            string inputSam = Console.ReadLine();
                            switch (inputSam)
                            {
                                case "1":
                                    Console.Clear();
                                    if (player._hp < player._Rhp * 0.3)
                                    {
                                        Console.WriteLine("체력이 조금 회복되는 듯 하다...");
                                        Thread.Sleep(1500);
                                        player._hp = player._Rhp * 0.3;
                                    }
                                    else
                                    {
                                        info.PrintSct("체력이 30% 미만일 때 주겠네");
                                    }
                                    break;
                                case "2":
                                    Console.Clear();
                                    if (player._gold >= 9000)
                                    {
                                        info.PrintSct("포툴카: 자, 쭉 들이키게!");
                                        Console.Clear();
                                        Console.WriteLine("피로가 싹 가시는 것 같다.");
                                        Thread.Sleep(1500);
                                        Console.Clear();
                                        player._gold -= 9000;
                                        player._hp = player._Rhp;
                                    }
                                    else
                                    {
                                        info.PrintSct("포툴카: 조금만 성의를 보여봐..~");
                                    }
                                    break;
                                case "3":
                                    Console.Clear();
                                    if (player._gold >= 40000)
                                    {
                                        info.PrintSct("포툴카: 두잔을 마시게나");
                                        Console.Clear();
                                        Console.WriteLine("생명력이 넘처 흐르는 것 같다..!!");
                                        Console.WriteLine(" 확인");
                                        Console.ReadLine();
                                        player._gold -= 40000;
                                        player._life += 1;
                                    }
                                    else
                                    {
                                        info.PrintSct("포툴카: 조금만 성의를 보여봐..~");
                                    }
                                    break;
                                case "0":
                                    boolSam = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case "5": // 모험
                        bool boolDGmenu = true;
                        while (boolDGmenu)
                        {
                            Console.Clear();
                            Console.WriteLine("[원시림]");
                            if (qc >= 1)
                                Console.WriteLine("1.검은숲");
                            if (qc >= 3)
                                Console.WriteLine("2.아홉의 해안");
                            Console.WriteLine("\n0.뒤로가기");

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
                                            Console.WriteLine("1.동굴 입구");
                                            if (mc >= 1)
                                                Console.WriteLine("2.서늘한 암석바위");
                                            if (mc >= 2)
                                                Console.WriteLine("3.피의 강");
                                            if (mc >= 3)
                                                Console.WriteLine("4.사제의 옥");
                                            if (mc >= 4)
                                                Console.WriteLine("5.(BOSS)가장 깊은 곳");
                                            Console.WriteLine("");
                                            Console.WriteLine("0.뒤로가기");

                                            string inputBF = Console.ReadLine();
                                            switch (inputBF)
                                            {
                                                case "1":
                                                    if (mc >= 0)
                                                    {
                                                        Console.Clear();
                                                        mon.Goblin1();
                                                        info.BattleMain(player, mon, mon2);
                                                        if (mon._hp == 0 && mc == 0)
                                                            mc = 1;
                                                    }
                                                    break;

                                                case "2":
                                                    if (mc >= 1)
                                                    {
                                                        Console.Clear();
                                                        mon.Goblin2();
                                                        info.BattleMain(player, mon, mon2);
                                                        if (mon._hp == 0 && mc <= 1)
                                                            mc = 2;
                                                    }
                                                    break;

                                                case "3":
                                                    if (mc >= 2)
                                                    {
                                                        Console.Clear();
                                                        mon.Goblin3();
                                                        info.BattleMain(player, mon, mon2);
                                                        if (mon._hp == 0 && mc <= 2)
                                                            mc = 3;
                                                    }
                                                    break;
                                                case "4":
                                                    if (mc >= 3)
                                                    {
                                                        Console.Clear();
                                                        mon.Goblin4();
                                                        info.BattleMain(player, mon, mon2);
                                                        if (mon._hp == 0 && mc <= 3)
                                                            mc = 4;
                                                    }
                                                    break;
                                                case "5":
                                                    if (mc >= 4)
                                                    {
                                                        Console.Clear();
                                                        mon.Goblin5();
                                                        info.BattleMain(player, mon, mon2);
                                                        if (mon._hp == 0 && mc <= 4)
                                                        {
                                                            info.PrintSct("동굴밖을 나오니 강이보인다.");
                                                            info.PrintSct($"{player._name}: 우선 그녀에게로 돌아가자..");
                                                            mc = 5;
                                                            qc = 2;
                                                        }
                                                    }
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
                                    if (qc >= 3)
                                    {
                                        bool boolNR = true;
                                        while (boolNR)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("[신전]");
                                            Console.WriteLine("1.바나하임 - [이동불가]");
                                            Console.WriteLine("2.알프하임");
                                            if (yotoonheimCount == 1)
                                                Console.WriteLine("3.요툰하임");
                                            else
                                                Console.WriteLine("3.요툰하임 - [이동불가]");
                                            Console.WriteLine("4.니플하임 - [이동불가]");
                                            Console.WriteLine("5.무스펠하임 - [이동불가]");
                                            if (hellheimCount == 1)
                                                Console.WriteLine("6.헬헤임");
                                            else
                                                Console.WriteLine("6.헬헤임 - [이동불가]");
                                            if (ASGDCount == 1)
                                                Console.WriteLine("7.아스가르드");
                                            else
                                                Console.WriteLine("7.아스가르드 - [이동불가]");
                                            Console.WriteLine("");
                                            Console.WriteLine("0.뒤로가기");

                                            string inputNR = Console.ReadLine();
                                            switch (inputNR)
                                            {
                                                case "1":
                                                    Console.Clear();
                                                    Console.WriteLine("차원이동석이 필요합니다.");
                                                    Thread.Sleep(1400);
                                                    break;

                                                case "2": // 1. 알프하임 > 엘프들만 있음
                                                    //Thread.Sleep(3000); 차원이동 중 애니 ㄱㄱ
                                                    info.Chawon();
                                                    bool boolElf = true;
                                                    while (boolElf)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("[알프하임]");
                                                        if (mc >= 5)
                                                            Console.WriteLine("1.엘프의숲");
                                                        if (mc >= 6)
                                                            Console.WriteLine("2.신전입구");
                                                        if (mc >= 7)
                                                            Console.WriteLine("3.(BOSS)엘프신전");
                                                        Console.WriteLine("\n0.미드가르드");

                                                        string inputElfMenu = Console.ReadLine();
                                                        switch (inputElfMenu)
                                                        {
                                                            case "1":
                                                                if (mc >= 5)
                                                                {
                                                                    Console.Clear();
                                                                    mon.Elf1();
                                                                    info.BattleMain(player, mon, mon2);
                                                                    if (mon._hp == 0 && mc <= 5)
                                                                        mc = 6;
                                                                }
                                                                break;

                                                            case "2":
                                                                if (mc >= 6)
                                                                {
                                                                    Console.Clear();
                                                                    mon.Elf2();
                                                                    info.BattleMain(player, mon, mon2);
                                                                    if (mon._hp == 0 && mc <= 6)
                                                                        mc = 7;
                                                                }
                                                                break;

                                                            case "3":
                                                                if (mc >= 7)
                                                                {
                                                                    Console.Clear();
                                                                    mon.Elf3();
                                                                    info.BattleMain(player, mon, mon2);
                                                                    if (mon._hp == 0 && mc <= 7)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("'헬헤임 차원이동석'을 획득하였습니다.");
                                                                        Thread.Sleep(1500);
                                                                        Console.Clear();
                                                                        Console.WriteLine("원하던 차원석은 아니군..\n우선 그녀에게로 가자");
                                                                        Thread.Sleep(1500);
                                                                        hellheimCount = 1;
                                                                        mc = 8;
                                                                        qc = 4;
                                                                    }
                                                                }
                                                                break;
                                                            case "0":
                                                                info.MidGa();
                                                                boolElf = false;
                                                                break;
                                                            default:
                                                                break;
                                                        }

                                                    }
                                                    break;
                                                case "3": // 3. 요툰하임 > 토르 혼자만
                                                    if (yotoonheimCount == 1)
                                                    {
                                                        info.Chawon();
                                                        if (firstYotoon == 1)
                                                        {
                                                            Console.Clear();
                                                            info.PrintSct("텅 비었군....");
                                                            info.PrintSct("정말 뼈 말곤 아무런 생명체가 없어..");
                                                            info.PrintSct("?!");
                                                            Console.Clear();
                                                            Console.WriteLine("꽈르릉!!!!!!!");
                                                            Thread.Sleep(1200);
                                                            info.PrintSct("하늘에서 낙뢰가..!!\n설마..");
                                                            info.PrintSct("???:요새 영역사이를 헤집고 다닌다는 애송이가 있다는데\n네 녀석인가 보군");
                                                            info.PrintSct("???:내 이름은 오딘의 아들 토르,");
                                                            info.PrintSct("토르: 천둥의 신이다.");
                                                            firstYotoon = 0;
                                                        }
                                                        bool boolyotoon = true;
                                                        while (boolyotoon)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("[요툰하임]");
                                                            Console.WriteLine("1.(BOSS)천둥의 신");
                                                            Console.WriteLine("\n0.미드가르드");

                                                            string inputHell = Console.ReadLine();
                                                            switch (inputHell)
                                                            {
                                                                case "1":
                                                                    if (mc >= 1)
                                                                    {
                                                                        Console.Clear();
                                                                        mon.Thor();
                                                                        info.BattleMain(player, mon, mon2);
                                                                        if (mon._hp == 0 && mc <= 10)
                                                                        {
                                                                            info.PrintSct("신드레를 죽일 때 함께 죽였어야 했는데...!!!");
                                                                            Console.Clear();
                                                                            Console.WriteLine("'아스가르드 차원이동석'을 획득하였습니다.");
                                                                            Thread.Sleep(1500);
                                                                            info.PrintSct("드디어,, 기다려라 오딘");
                                                                            Console.Clear();
                                                                            Console.WriteLine("프레이아에게로 돌아갑니다.");
                                                                            Thread.Sleep(1500);
                                                                            qc = 8;
                                                                            ASGDCount = 1;
                                                                            mc = 11;
                                                                        }
                                                                    }
                                                                    break;
                                                                case "0":
                                                                    info.MidGa();
                                                                    boolyotoon = false;
                                                                    break;
                                                                default:
                                                                    break;

                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("차원이동석이 필요합니다.");
                                                        Thread.Sleep(1400);
                                                    }
                                                    break;
                                                case "4":
                                                    Console.Clear();
                                                    Console.WriteLine("차원이동석이 필요합니다.");
                                                    Thread.Sleep(1400);
                                                    break;
                                                case "5":
                                                    Console.Clear();
                                                    Console.WriteLine("차원이동석이 필요합니다.");
                                                    Thread.Sleep(1400);
                                                    break;
                                                case "6": // 2. 티르(오딘한테 지고) 망령1 + 티르 두명
                                                    if (hellheimCount == 1)
                                                    {
                                                        info.Chawon();
                                                        bool boolHell = true;
                                                        while (boolHell)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("[헬헤임]");
                                                            Console.WriteLine("1.악인의 망령");
                                                            if (mc >= 9)
                                                                Console.WriteLine("2.(BOSS)전쟁의 신");
                                                            Console.WriteLine("\n0.미드가르드");

                                                            string inputHell = Console.ReadLine();
                                                            switch (inputHell)
                                                            {
                                                                case "1":
                                                                    if (mc >= 8)
                                                                    {
                                                                        Console.Clear();
                                                                        mon.Ghost1();
                                                                        info.BattleMain(player, mon, mon2);
                                                                        if (mon._hp == 0 && mc <= 8)
                                                                            mc = 9;
                                                                    }
                                                                    break;
                                                                case "2":
                                                                    if (mc >= 9)
                                                                    {
                                                                        Console.Clear();
                                                                        mon.Tyr();
                                                                        info.BattleMain(player, mon, mon2);
                                                                        if (mon._hp == 0 && mc <= 9)
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("'요툰하임 차원이동석'을 획득하였습니다.");
                                                                            Thread.Sleep(1500);
                                                                            info.PrintSct("힘든 전투였다....");
                                                                            info.PrintSct("하지만 아스가르드의 차원석은 아니군...");
                                                                            info.PrintSct("우선 그녀에게로 돌아가자");
                                                                            yotoonheimCount = 1;
                                                                            mc = 10;
                                                                            qc = 6;
                                                                        }
                                                                    }
                                                                    break;
                                                                case "0":
                                                                    info.MidGa();
                                                                    boolHell = false;
                                                                    break;
                                                                default:
                                                                    break;

                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("차원이동석이 필요합니다.");
                                                        Thread.Sleep(1400);
                                                    }
                                                    break;
                                                case "7": // 헤임달, 오딘(발키리 소환) 순
                                                    if (ASGDCount == 1)
                                                    {
                                                        info.Chawon();
                                                        bool boolASGD = true;
                                                        while (boolASGD)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("[아스가르드]");
                                                            Console.WriteLine("1.비프로스트");
                                                            if (mc >= 12)
                                                                Console.WriteLine("2.(BOSS)발할라");
                                                            Console.WriteLine("\n0.미드가르드");

                                                            string inputHell = Console.ReadLine();
                                                            switch (inputHell)
                                                            {
                                                                case "1":
                                                                    if (mc >= 11)
                                                                    {
                                                                        Console.Clear();
                                                                        mon.Heimdal();
                                                                        info.BattleMain(player, mon, mon2);
                                                                        if (mon._hp == 0 && mc <= 11)
                                                                            mc = 12;
                                                                    }
                                                                    break;
                                                                case "2":
                                                                    if (mc >= 12)
                                                                    {
                                                                        Console.Clear();

                                                                        mon.God();
                                                                        info.BattleMain(player, mon, mon2);
                                                                        if (mon._hp == 0 && mc <= 12)
                                                                        {
                                                                            info.PrintSct("내가... 패하다니...");
                                                                            info.PrintSct("예언의 라그나로크가 \n네 녀석이었을 줄이야...");
                                                                            info.PrintSct(".....");
                                                                            Console.Clear();
                                                                            Console.WriteLine("쿠...구궁....");
                                                                            Thread.Sleep(1200);
                                                                            Console.Clear();
                                                                            Console.WriteLine("드..ㄷ,,드ㅡ드드ㅡ,,");
                                                                            Thread.Sleep(1200);
                                                                            info.PrintSct("아스가르드가 붕괴하기 시작했다.");
                                                                            info.PrintSct("어서빨리 탈출해야돼..!!!!");
                                                                            Console.Clear();
                                                                            Console.WriteLine("...");
                                                                            Thread.Sleep(800);
                                                                            Console.Clear();
                                                                            Console.WriteLine("......");
                                                                            Thread.Sleep(800);
                                                                            Console.Clear();
                                                                            Console.WriteLine(".........");
                                                                            Thread.Sleep(800);
                                                                            info.PrintSct("- 9년뒤 -");
                                                                            info.PrintSct("신이 없는 세상은 평화로웠다.");
                                                                            info.PrintSct("하지만 피밖에 남지 않은 전쟁으로 나는 피폐해졌고,\n29살의 나이로 세상을 떠났다.");
                                                                            info.PrintSct("내 아버지 신드레가 벌인 전쟁은 이렇게 끝이났다.");
                                                                            Console.Clear();
                                                                            Console.WriteLine("신드레 전쟁");
                                                                            Console.WriteLine("     The End...");
                                                                            Console.ReadLine();
                                                                            qc = 10;
                                                                        }
                                                                    }
                                                                    break;
                                                                case "0":
                                                                    info.MidGa();
                                                                    boolASGD = false;
                                                                    break;
                                                                default:
                                                                    break;

                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("차원이동석이 필요합니다.");
                                                        Thread.Sleep(1400);
                                                    }
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
                        bool boolMine = true;
                        while (boolMine)
                        {
                            Console.Clear();
                            Console.WriteLine("[광산]");
                            Console.WriteLine($"보유중인 광석: {stone}개");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine($"1.채굴하기(곡괭이 내구성: {pick})");
                            Console.WriteLine("");
                            Console.WriteLine("0.뒤로가기");
                            string inputMine = Console.ReadLine();
                            switch (inputMine)
                            {
                                case "1":
                                    if (pick >= 1)
                                    {
                                        Random mining = new Random();
                                        int miningC = mining.Next(1, 10);
                                        if (miningC == 1)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("광석을 캐냈다!");
                                            Thread.Sleep(300);
                                            stone += 1;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("그냥 돌이군..");
                                            Thread.Sleep(300);
                                        }
                                        pick -= 1;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("내구성이 모두 떨어졌습니다.");
                                        Console.ReadLine();
                                    }
                                    break;
                                case "0":
                                    boolMine = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case "영역":
                        stone += 50;
                        player._gold += 50000;
                        /*qc = 3;
                        hellheimCount = 1;
                        yotoonheimCount = 1;
                        ASGDCount = 1;
                        mc = 13;*/
                        break;

                    default:
                        break;

                } // menu switch end

            } // 태초의 while E.N.D !!!!!!!!





        } //main END
    } // Class Program End
} // namespace End




