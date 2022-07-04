namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_241_250
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_241_test()
        {
            if (tasksList.t_List.Length > 240)
                Assert.That(tasksList.t_List[240].answer(), Is.EqualTo("482316491800641154"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_242_test()
        {
            if (tasksList.t_List.Length > 241)
                Assert.That(tasksList.t_List[241].answer(), Is.EqualTo("997104142249036713"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_243_test()
        {
            if (tasksList.t_List.Length > 242)
                Assert.That(tasksList.t_List[242].answer(), Is.EqualTo("892371480"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_244_test()
        {
            if (tasksList.t_List.Length > 243)
                Assert.That(tasksList.t_List[243].answer(), Is.EqualTo("96356848"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_245_test()
        {
            if (tasksList.t_List.Length > 244)
                Assert.That(tasksList.t_List[244].answer(), Is.EqualTo("288084712410001"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_246_test()
        {
            if (tasksList.t_List.Length > 245)
                Assert.That(tasksList.t_List[245].answer(), Is.EqualTo("810834388"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_247_test()
        {
            if (tasksList.t_List.Length > 246)
                Assert.That(tasksList.t_List[246].answer(), Is.EqualTo("782252"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_248_test()
        {
            if (tasksList.t_List.Length > 247)
                Assert.That(tasksList.t_List[247].answer(), Is.EqualTo("23507044290"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_249_test()
        {
            if (tasksList.t_List.Length > 248)
                Assert.That(tasksList.t_List[248].answer(), Is.EqualTo("9275262564250418"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_250_test()
        {
            if (tasksList.t_List.Length > 249)
                Assert.That(tasksList.t_List[249].answer(), Is.EqualTo("1425480602091519"));
            else
                Assert.Ignore();
        }
    }
}
