namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_211_220
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_211_test()
        {
            if (tasksList.t_List.Length > 210)
                Assert.That(tasksList.t_List[210].answer(), Is.EqualTo("1922364685"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_212_test()
        {
            if (tasksList.t_List.Length > 211)
                Assert.That(tasksList.t_List[211].answer(), Is.EqualTo("328968937309"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_213_test()
        {
            if (tasksList.t_List.Length > 212)
                Assert.That(tasksList.t_List[212].answer(), Is.EqualTo("330.721154"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_214_test()
        {
            if (tasksList.t_List.Length > 213)
                Assert.That(tasksList.t_List[213].answer(), Is.EqualTo("1677366278943"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_215_test()
        {
            if (tasksList.t_List.Length > 214)
                Assert.That(tasksList.t_List[214].answer(), Is.EqualTo("806844323190414"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_216_test()
        {
            if (tasksList.t_List.Length > 215)
                Assert.That(tasksList.t_List[215].answer(), Is.EqualTo("5437849"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_217_test()
        {
            if (tasksList.t_List.Length > 216)
                Assert.That(tasksList.t_List[216].answer(), Is.EqualTo("6273134"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_218_test()
        {
            if (tasksList.t_List.Length > 217)
                Assert.That(tasksList.t_List[217].answer(), Is.EqualTo("0"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_219_test()
        {
            if (tasksList.t_List.Length > 218)
                Assert.That(tasksList.t_List[218].answer(), Is.EqualTo("64564225042"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_220_test()
        {
            if (tasksList.t_List.Length > 219)
                Assert.That(tasksList.t_List[219].answer(), Is.EqualTo("139776,963904"));
            else
                Assert.Ignore();
        }
    }
}
