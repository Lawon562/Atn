using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TextRPG.Scenes;
using TextRPG.Character;
using TextRPG.Object;
/*
* 프로젝트 이름 : 
* 개발 일자 : 2023.01.19
* 프로젝트 설명 : Console로 플레이하는 Text RPG
*/

namespace TextRPG
{
    class Program
    {

        //public static Player player = new Player("당신");
        
        //------------
        static void Main(string[] args)
        {
            Settings.Set();
            while (Key.game)
            {
                Common.ResetScreen();
                int select = TitleScene.Play();
                //int select = 1;
                Console.Clear();
                if (select == 1)
                {
                    IntroScene.Play();
                    
                    TextColor.ForeWhite();

                    Player player = Player.GetInstance();
                    player.Name = "당신";

                    string mapName = "소울 스트림";
                    SceneUIFunc.WriteUI(mapName, Key.naoIntro, true);
                   
                    NonePlayerCharacter nao = new NonePlayerCharacter("나오");
                    
                    
                    nao.Say(new[]{
                        "안녕하세요? 당신이 도착하길 기다리고 있었어요.",
                        "제 이름은 나오라고 해요. 당신같이 순수한 영혼을 에린으로 인도하는 것이 제 역할입니다. 만나서 반가워요.",
                        "우선, 당신이 에린에서 불릴 이름을 알려주실 수 있으실까요? "
                    });

                    // 나레이션
                    Common.narration("(당신의 이름을 입력해주세요) : ");

                    player.Name = Common.PlayerInput();

                    player.Say($"『{player.Name}』 (이)야.");


                    nao.Say($"{player.Name}..{player.Name}님 이시군요.");
                    nao.WriteLines(new[] {
                        "이곳 소울 스트림에선 당신의 성별을 선택할 수 있어요.",
                        "당신의 성별을 선택해주시겠어요?"
                    });


                    // 나레이션
                    Common.narration("(다음 성별 중 하나를 선택해 주세요.)");

                    player.Gender = Common.getBtnStr(new[] { "남자", "여자" });
                    //player.Say($"나는 {player.Gender}야.");
                    

                    nao.Say(new[] { 
                        $"감사합니다, {player.Name}님.",
                        $"{player.Name}님을 에린으로 안내해드리기 전에 약간은 시간이 있을 것 같은데 혹시 좀 더 자세한 얘기를 듣고 싶으세요?"
                    });


                    // 나레이션
                    Common.narration("(나오가 싱긋 웃어보이며 이야기한다.)");


                    string answer;
                    do
                    {
                        nao.Say("혹시 알고 싶은 게 있다면 지금 물어보세요.");

                        answer = Common.getBtnStr(new[]
                        {
                            "마비노기란 무엇인가요 ?",
                            "에린이란 무엇인가요 ?",
                            "나는 뭘 하면 되나요 ?",
                            "멋진 모험을 하려면?",
                            "궁금한 건 없어"
                        }, false);
                    } while (!answer.Equals("궁금한 건 없어"));
                    
                    
                    nao.Say(new[] {
                        "다음에 뵐 때에는 아마 재능을 선택하시게 될 거예요.",
                        "그때까지 다양한 것들을 겪어 보시며, 건강하게 지내시길 바랄게요." });

                    nao.WriteLines(new[]
                    {
                        "마음의 준비는 되셨죠...?",
                        "이제 에린으로 보내드리도록 할게요.",
                        $"{player.Name}님을 기다리고 있는 분들이 계시답니다.",
                        "도움이 될 만한 얘길 해주실테니, 만나서 대화를 나눠보세요."
                    });


                    // 나레이션
                    Common.narration("(나오로부터 빵과 여행자 가이드, 나오의 영혼석을 받았다.)");

                    nao.Say(new[] {
                        $"{player.Name}님이 에린에서 살아가는 데 필요한 여러가지 것들을 배울 수 있을 거예요.",
                        "그 곳에서 가르쳐 주는 것을 다 배우고 난 후에 원하시는 새로운 세계를 경험해 보도록 하세요."
                    });

                    nao.WriteLines(new[] {
                        "에린에서의 모든 일에 행운이 함께 하시길 기원할게요.",
                        $"그럼 또 만나요. {player.Name}님." 
                    });

                    TextColor.ResetColor();
                    Console.ReadLine();
                    
                }
                else if (select == 4)
                {
                    Common.Exit();
                }
            }
        }
        //------------
        
        
    }
}
