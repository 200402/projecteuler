namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_181_190
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_181_test()
        {
            if (tasksList.t_List.Length > 180)
                Assert.That(tasksList.t_List[180].answer(), Is.EqualTo("83735848679360680"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_182_test()
        {
            if (tasksList.t_List.Length > 181)
                Assert.That(tasksList.t_List[181].answer(), Is.EqualTo("399788195976"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_183_test()
        {
            if (tasksList.t_List.Length > 182)
                Assert.That(tasksList.t_List[182].answer(), Is.EqualTo("48861552"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_184_test()
        {
            if (tasksList.t_List.Length > 183)
                Assert.That(tasksList.t_List[183].answer(), Is.EqualTo("1725323624056"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_185_test()
        {
            if (tasksList.t_List.Length > 184)
                Assert.That(tasksList.t_List[184].answer(), Is.EqualTo("4640261571849533"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_186_test()
        {
            if (tasksList.t_List.Length > 185)
                Assert.That(tasksList.t_List[185].answer(), Is.EqualTo("2325629"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_187_test()
        {
            if (tasksList.t_List.Length > 186)
                Assert.That(tasksList.t_List[186].answer(), Is.EqualTo("17427258"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_188_test()
        {
            if (tasksList.t_List.Length > 187)
                Assert.That(tasksList.t_List[187].answer(), Is.EqualTo("95962097"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_189_test()
        {
            if (tasksList.t_List.Length > 188)
                Assert.That(tasksList.t_List[188].answer(), Is.EqualTo("10834893628237824"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_190_test()
        {
            if (tasksList.t_List.Length > 189)
                Assert.That(tasksList.t_List[189].answer(), Is.EqualTo("371048281"));
            else
                Assert.Ignore();
        }
    }
}
