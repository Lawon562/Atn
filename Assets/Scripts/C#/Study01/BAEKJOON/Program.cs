using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.Lv1_Test();
            //program.Lv2_Test();
            //program.Lv3_Test();
            //program.Lv4_Test();
            program.Lv5_Test();
        }


        public void Lv1_Test()
        {
            Level1 level1 = new Level1();
            //  level1.Q2257();     // OK
            //  level1.Q1000();     // OK
            //  level1.Q1001();     // OK
            //  level1.Q10998();    // OK
            //  level1.Q1008();     // OK
            //  level1.Q10869();    // OK
            //  level1.Q10926();    // OK
            //  level1.Q18108();    // OK
            //  level1.Q3003();     // OK
            //  level1.Q10430();    // OK
            //  level1.Q2588();     // OK
            //  level1.Q10171();    // OK
            //  level1.Q10172();    // OK
            //  level1.Q25083();    // OK
        }


        public void Lv2_Test()
        {
            Level2 level2 = new Level2();
            //  level2.Q1330();     // OK
            //  level2.Q9498();     // OK
            //  level2.Q2753();     // OK
            //  level2.Q14681();    // OK
            //  level2.Q2884();     // OK
            //  level2.Q2525();     // OK
            //  level2.Q2480();     // OK
        }

        public void Lv3_Test()
        {
            Level3 level3 = new Level3();
            //  level3.Q2739();     // OK
            //  level3.Q10950();    // OK
            //  level3.Q8393();     // OK
            //  level3.Q25304();    // OK
            //  level3.Q15552();    // OK
            //  level3.Q11021();    // OK
            //  level3.Q11022();    // OK
            //  level3.Q2438();     // OK
            //  level3.Q2439();     // OK
            //  level3.Q10952();    // OK
            //  level3.Q10951();    // OK
            //  level3.Q1110();     // OK

        }
        public void Lv4_Test()
        {
            Level4 level4 = new Level4();
            //  level4.Q10807();    //OK
            //  level4.Q10871();    //OK
            //  level4.Q10818();    //OK
            //  level4.Q2562();     //OK
            //  level4.Q5597();     //OK
            //  level4.Q3052();     //OK
            //  level4.Q1546();     //OK
            //  level4.Q8958();     //OK
            //  level4.Q4344();     //OK
        }

        public void Lv5_Test()
        {
            Level5 level5 = new Level5();
            //  level5.Q15596();    //OK
            //  level5.Q4673();     //OK
            level5.Q1065();
        }
    }
}
