namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_221_230
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_221_test()
        {
            if (tasksList.t_List.Length > 220)
                Assert.That(tasksList.t_List[220].answer(), Is.EqualTo("1884161251122450"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_222_test()
        {
            if (tasksList.t_List.Length > 221)
                Assert.That(tasksList.t_List[221].answer(), Is.EqualTo("1590933"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_223_test()
        {
            if (tasksList.t_List.Length > 222)
                Assert.That(tasksList.t_List[222].answer(), Is.EqualTo("61614848"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_224_test()
        {
            if (tasksList.t_List.Length > 223)
                Assert.That(tasksList.t_List[223].answer(), Is.EqualTo("4137330"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_225_test()
        {
            if (tasksList.t_List.Length > 224)
                Assert.That(tasksList.t_List[224].answer(), Is.EqualTo("2009"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_226_test()
        {
            if (tasksList.t_List.Length > 225)
                Assert.That(tasksList.t_List[225].answer(), Is.EqualTo("0.11316017"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_227_test()
        {
            if (tasksList.t_List.Length > 226)
                Assert.That(tasksList.t_List[226].answer(), Is.EqualTo("3780.618622"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_228_test()
        {
            if (tasksList.t_List.Length > 227)
                Assert.That(tasksList.t_List[227].answer(), Is.EqualTo("86226"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_229_test()
        {
            if (tasksList.t_List.Length > 228)
                Assert.That(tasksList.t_List[228].answer(), Is.EqualTo("11325263"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_230_test()
        {
            if (tasksList.t_List.Length > 229)
                Assert.That(tasksList.t_List[229].answer(), Is.EqualTo("850481152593119296"));
            else
                Assert.Ignore();
        }
    }
}
