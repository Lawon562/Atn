using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Character;

namespace TextRPG.Scenes
{
    /*
     * 눈 앞의 빛이 사그라들자, 나무로 둘러쌓인 작은 공터가 나타났다.



- 튜토리얼을 시작한다 -
 ->

     */
    class Chapter1Scene_TutorialZone
    {
        public int Play()
        {
            // Player 생성
            Player player = Player.GetInstance();

            NonePlayerCharacter lorna = new NonePlayerCharacter("로나", "여성", ConsoleColor.Cyan);
            NonePlayerCharacter pan = new NonePlayerCharacter("판", "남성", ConsoleColor.Gray);
            NonePlayerCharacter tin = new NonePlayerCharacter("틴", "남성", ConsoleColor.DarkGray);

            // 현재 맵 이름
            string mapName = "튜토리얼 존";

            // UI 생성
            SceneUIFunc.WriteUI(
                mapName,
                new[] {
                    "눈 앞의 빛이 사그라들자, 나무로 둘러쌓인 작은 공터가 나타났다.",
                    "따듯한 햇살 아래 수풀에는 이름 모를 하얀 꽃이 피어있고, 병아리와 닭들은 그 주변 땅을 쪼고 있다.",
                    "주변을 살펴보니 검은 양과 그 옆에 서서 투닥거리는 작은 소녀가 보인다."
                },
                true
            );

            
            string answer = "";
            while (true)
            {
                Common.narration("무엇을 할까?");
                answer = Common.getBtnStr(new[]
                {
                    " - 주변에 보이는 인물에게 말을 걸어보기",
                    " - 이동하기"
                }, false);
                if (answer.Equals(" - 주변에 보이는 인물에게 말을 걸어보기"))
                {
                    Common.narration("대화를 할 상대를 골라주세요.");
                    answer = Common.getBtnStr(new[] { "작은 소녀", "검은 양" });
                    break;
                }
                else if (answer.Equals(" - 이동하기"))
                {
                    Common.narration("이동할 수 있는 장소가 없는 것 같다...");
                }
            }


            if (answer == "검은 양")
            {
                Common.narration(new[]
                {
                    "보통의 양과 다르게 윤기 흐르는 검은 털을 가진 양.",
                    "부드러워 보이는 털은 복슬복슬해서 폭 파묻히고 싶은 기분이 들게 한다."
                });

                pan.Say("오, 나에게 먼저 말을 걸 줄은 몰랐는걸? 정말 반가워. 나도 이야기를 하고싶지만 로나가 하고 싶은 말이 있는 것 같으니 로나와 먼저 대화했으면 좋겠어.");
            }

            Common.narration(new[]
            {
                "편안해보이는 스커트를 입고 있는 작은 소녀.",
                "자그마한 얼굴에 생기 넘치는 푸른 눈이 돋보인다.",
                "눈이 마주치자 얼굴 가득 호의를 담고 반갑게 말을 건네 온다."
            });

            lorna.Say(new[] {
                "어머! 안녕!",
                "아니, 안녕하세요! 라고 해야 하나?",
                $"일단 반가워, {player.Name}! 난 로나라고 해.",
                "",
                "네가 온다는 소식을 듣고, 도움을 주려고 기다리고 있었어.",
                "에린에 적응하기 위한 간단한 것들을 내가 알려주려고 해!",
                "",
                "나도 많이 부족하지만... 헤헤."
            });

            pan.Say(new[]
            {
                "로나, 침착하고 천천히 말해.",
                $"{ player.Name}(은)는 여기에 방금 막 도착했다구.",
                "여기가 어딘지부터 찬찬히 설명해 줘."
            });

            lorna.Say(new[]
            {
                $"헤헤... 여기는 { player.Name}같은 초보자들을 위한 곳이야.",
                "간단한 조작법, 기본적인 정보, 전투 방법처럼 마비노기 세계의 기초적인 것에 대해 배울 수 있는 특별한 곳이지."
            });

            Common.narration("(로나가 해맑게 웃어보인다)");


            lorna.WriteLines(new[]
            {
                "나랑 판은 일종의 선생님? 후훗.",
                "에린에서 앞으로 지내면서 필요한 것들을 많이 알려줄게.",
                "",
                "음... 너무 간단한 것들이라서 배우지 않아도 된다면, 바로 에린으로 가도 좋아.",
                "하지만 열심히 준비했으니까, 괜찮다면 잠깐 들어주지 않을래?",
                "이 과정을 전부 듣는다면 나중에 나랑 판이 정성들여서 마련한 특별한 선물도 줄게!"
            });


            pan.Say("그렇지.모든 초보자 과정이 끝났을 때 나의 분신같은 마법 빗자루 펫까지 얻을 수 있지.");

            lorna.Say(new[]
            {
                "그렇지! 누가 만든 건데.",
                $"내가 { player.Name}을(를) 기다리며 정성스럽게 제작한 튼튼한 마법빗자루인 걸!",
                "분명 마음에 들 거야!"
            });


            answer = Common.getBtnStr(new[] { "튜토리얼을 시작한다", "에린으로 떠난다" });

            if (answer.Equals("튜토리얼을 시작한다."))
            {
                lorna.Say(new[]
                {
                    "헤헤.그럼 시작해볼까?",
                    "여기에서 간단하게 조작법과 전투 방법을 배우고 나서 월드로 이동하자.",
                    "긴 시간이 필요하진 않을거야!",
                    "하지만 만약에 그만두고 빨리 월드로 나가고 싶다면...",
                    "화면 오른쪽 위의 SKIP 버튼을 누르면 돼."
                });

                pan.Say(new[] { "하자민 앞으로 로나의 미련 가득한 눈빛을 받게 될지도 모르지.", "로나 얘가 안그래보여도 뒤끝이 엄청나거든." });

                lorna.Say(new[]
                {
                    "무슨 말을 하는 거야, 판.",
                    "나... 나는 괜찮다구!비록 오랜만의 할 일이라 설랜 건 사실이지만...",
                    "....으, 으음... 어쨋든! 그럼 시작해볼까?",
                    "",
                    "일단 대화를 끝낸 후 나에게 다시 말을 걸어 줄래 ?"
                });
            }
            else if (answer.Equals("에린으로 떠난다"))
            {
                pan.Say("메에에, 튜토리얼을 스킵하다니 아쉽지만...");

                Common.narration("(로나의 설렘 가득한 얼굴이 순식간에 시무룩한 표정으로 바뀌었다.)");

                lorna.Say(new[]
                {
                    $"정말 많이 준비했는데... 바쁘다면 어쩔 수 없지.",
                    "에린에 가서도 좋은 일이 가득하길 바랄게!",
                    "화이팅!!!"
                });

                Common.narration("(로나의 응원을 마지막으로 몸이 붕 뜨는 것이 느껴졌다...)");
                Key.lastLine++;
                Common.WriteNextScene("아무 키나 눌러주세요 . . .", true);

                Common.ClearInputBuffer();
                Console.ReadLine();
                return 0;
            }
            

            /*
             * 우측 메뉴 소개
             */

            // 마스터 틴 등장
            /*
             * 전투 소개
             */
            Common.narration(new[]
            {
                "조그만 꼬마가 무거워 보이는 투구를 머리에 쓰고 이쪽을 바라본다.",
                "용이 장식된 투구는 잘 손질된 듯 번쩍이는데, 안에 보이는 얼굴을 알아보기는 힘들다.",
                "때로 버릇처럼 왼손을 턱에 살짝 괴고 약간 잠긴 목소리로 말을 하는데, 그때마다 투구가 약간씩 미끄러지는 것 같다."
            });
            tin.Say(new[]
            {
                $"흐음, 네가 {player.Name}?",
                "기다리고 있었어.",
                "나는 틴, 지금부터 너에게 에린에서의 전투에 대해 알려줄 거야.",
                "",
                "본격적으로 수업을 시작하기 전에..."
            });

            Common.narration(new[]
            {
                "틴이 공터의 한 켠을 바라보고 있다.",
                "시선을 따라가보니, 사나워보이는 너구리들이 공터를 파헤치고 있었다."
            });

            tin.Say(new[]
            {
                "저기 있는 너구리를 다섯마리 정도 잡아볼까?",
                "그래, 너구리들 말이야.",
                "저 녀석들, 원래는 사람을 공격하지 않는데 [포워르]라고 하는 자들이 조종해서 사람을 공격하게 된 녀석들이야.",
                "저 녀석들의 Hp가 다 떨어져서 기절하면, 조종받지 않게 될거야.",
            });

            Common.narration("(너구리를 잡아보자.)");

            // 전투

            string target = Common.getBtnStr(new[]
            {
                "너구리",
                "너구리",
                "너구리",
                "너구리",
                "너구리",
            });

            Common.Battle(target);

            Key.lastLine++;
            Common.WriteNextScene("아무 키나 눌러주세요 . . .", true);

            Common.ClearInputBuffer();
            Console.ReadLine();
            return 1;
        }

        
    }
}