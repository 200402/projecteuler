namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_231_240
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_231_test()
        {
            if (tasksList.t_List.Length > 230)
                Assert.That(tasksList.t_List[230].answer(), Is.EqualTo("7526965179680"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_232_test()
        {
            if (tasksList.t_List.Length > 231)
                Assert.That(tasksList.t_List[231].answer(), Is.EqualTo("0.83648556"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_233_test()
        {
            if (tasksList.t_List.Length > 232)
                Assert.That(tasksList.t_List[232].answer(), Is.EqualTo("271204031455541309"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_234_test()
        {
            if (tasksList.t_List.Length > 233)
                Assert.That(tasksList.t_List[233].answer(), Is.EqualTo("1259187438574927161"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_235_test()
        {
            if (tasksList.t_List.Length > 234)
                Assert.That(tasksList.t_List[234].answer(), Is.EqualTo("1.002322108633"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_236_test()
        {
            if (tasksList.t_List.Length > 235)
                Assert.That(tasksList.t_List[235].answer(), Is.EqualTo("123/59"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_237_test()
        {
            if (tasksList.t_List.Length > 236)
                Assert.That(tasksList.t_List[236].answer(), Is.EqualTo("15836928"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_238_test()
        {
            if (tasksList.t_List.Length > 237)
                Assert.That(tasksList.t_List[237].answer(), Is.EqualTo("9922545104535661"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_239_test()
        {
            if (tasksList.t_List.Length > 238)
                Assert.That(tasksList.t_List[238].answer(), Is.EqualTo("0.001887854841"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_240_test()
        {
            if (tasksList.t_List.Length > 239)
                Assert.That(tasksList.t_List[239].answer(), Is.EqualTo("7448717393364181966"));
            else
                Assert.Ignore();
        }
    }
}
