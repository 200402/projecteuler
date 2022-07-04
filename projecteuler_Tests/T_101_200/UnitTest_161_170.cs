namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_161_170
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_161_test()
        {
            if (tasksList.t_List.Length > 160)
                Assert.That(tasksList.t_List[160].answer(), Is.EqualTo("20574308184277971"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_162_test()
        {
            if (tasksList.t_List.Length > 161)
                Assert.That(tasksList.t_List[161].answer(), Is.EqualTo("3D58725572C62302"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_163_test()
        {
            if (tasksList.t_List.Length > 162)
                Assert.That(tasksList.t_List[162].answer(), Is.EqualTo("343047"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_164_test()
        {
            if (tasksList.t_List.Length > 163)
                Assert.That(tasksList.t_List[163].answer(), Is.EqualTo("378158756814587"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_165_test()
        {
            if (tasksList.t_List.Length > 164)
                Assert.That(tasksList.t_List[164].answer(), Is.EqualTo("2868868"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_166_test()
        {
            if (tasksList.t_List.Length > 165)
                Assert.That(tasksList.t_List[165].answer(), Is.EqualTo("7130034"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_167_test()
        {
            if (tasksList.t_List.Length > 166)
                Assert.That(tasksList.t_List[166].answer(), Is.EqualTo("3916160068885"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_168_test()
        {
            if (tasksList.t_List.Length > 167)
                Assert.That(tasksList.t_List[167].answer(), Is.EqualTo("59206"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_169_test()
        {
            if (tasksList.t_List.Length > 168)
                Assert.That(tasksList.t_List[168].answer(), Is.EqualTo("178653872807"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_170_test()
        {
            if (tasksList.t_List.Length > 169)
                Assert.That(tasksList.t_List[169].answer(), Is.EqualTo("9857164023"));
            else
                Assert.Ignore();
        }
    }
}
