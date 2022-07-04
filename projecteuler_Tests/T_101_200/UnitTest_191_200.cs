namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_191_200
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_191_test()
        {
            if (tasksList.t_List.Length > 190)
                Assert.That(tasksList.t_List[190].answer(), Is.EqualTo("1918080160"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_192_test()
        {
            if (tasksList.t_List.Length > 191)
                Assert.That(tasksList.t_List[191].answer(), Is.EqualTo("57060635927998347"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_193_test()
        {
            if (tasksList.t_List.Length > 192)
                Assert.That(tasksList.t_List[192].answer(), Is.EqualTo("684465067343069"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_194_test()
        {
            if (tasksList.t_List.Length > 193)
                Assert.That(tasksList.t_List[193].answer(), Is.EqualTo("61190912"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_195_test()
        {
            if (tasksList.t_List.Length > 194)
                Assert.That(tasksList.t_List[194].answer(), Is.EqualTo("75085391"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_196_test()
        {
            if (tasksList.t_List.Length > 195)
                Assert.That(tasksList.t_List[195].answer(), Is.EqualTo("322303240771079935"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_197_test()
        {
            if (tasksList.t_List.Length > 196)
                Assert.That(tasksList.t_List[196].answer(), Is.EqualTo("1.710637717"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_198_test()
        {
            if (tasksList.t_List.Length > 197)
                Assert.That(tasksList.t_List[197].answer(), Is.EqualTo("52374425"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_199_test()
        {
            if (tasksList.t_List.Length > 198)
                Assert.That(tasksList.t_List[198].answer(), Is.EqualTo("0.00396087"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_200_test()
        {
            if (tasksList.t_List.Length > 199)
                Assert.That(tasksList.t_List[199].answer(), Is.EqualTo("229161792008"));
            else
                Assert.Ignore();
        }
    }
}
