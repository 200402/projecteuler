namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_451_460
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_451_test()
        {
            if (tasksList.t_List.Length > 450)
                Assert.That(tasksList.t_List[450].answer(), Is.EqualTo("153651073760956"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_452_test()
        {
            if (tasksList.t_List.Length > 451)
                Assert.That(tasksList.t_List[451].answer(), Is.EqualTo("345558983"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_453_test()
        {
            if (tasksList.t_List.Length > 452)
                Assert.That(tasksList.t_List[452].answer(), Is.EqualTo("104354107"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_454_test()
        {
            if (tasksList.t_List.Length > 453)
                Assert.That(tasksList.t_List[453].answer(), Is.EqualTo("5435004633092"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_455_test()
        {
            if (tasksList.t_List.Length > 454)
                Assert.That(tasksList.t_List[454].answer(), Is.EqualTo("450186511399999"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_456_test()
        {
            if (tasksList.t_List.Length > 455)
                Assert.That(tasksList.t_List[455].answer(), Is.EqualTo("333333208685971546"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_457_test()
        {
            if (tasksList.t_List.Length > 456)
                Assert.That(tasksList.t_List[456].answer(), Is.EqualTo("2647787126797397063"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_458_test()
        {
            if (tasksList.t_List.Length > 457)
                Assert.That(tasksList.t_List[457].answer(), Is.EqualTo("423341841"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_459_test()
        {
            if (tasksList.t_List.Length > 458)
                Assert.That(tasksList.t_List[458].answer(), Is.EqualTo("3996390106631"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_460_test()
        {
            if (tasksList.t_List.Length > 459)
                Assert.That(tasksList.t_List[459].answer(), Is.EqualTo("18.420738199"));
            else
                Assert.Ignore();
        }
    }
}
