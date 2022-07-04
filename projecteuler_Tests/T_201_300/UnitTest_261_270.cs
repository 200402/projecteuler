namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_261_270
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_261_test()
        {
            if (tasksList.t_List.Length > 260)
                Assert.That(tasksList.t_List[260].answer(), Is.EqualTo("238890850232021"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_262_test()
        {
            if (tasksList.t_List.Length > 261)
                Assert.That(tasksList.t_List[261].answer(), Is.EqualTo("2531.205"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_263_test()
        {
            if (tasksList.t_List.Length > 262)
                Assert.That(tasksList.t_List[262].answer(), Is.EqualTo("2039506520"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_264_test()
        {
            if (tasksList.t_List.Length > 263)
                Assert.That(tasksList.t_List[263].answer(), Is.EqualTo("2816417.1055"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_265_test()
        {
            if (tasksList.t_List.Length > 264)
                Assert.That(tasksList.t_List[264].answer(), Is.EqualTo("209110240768"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_266_test()
        {
            if (tasksList.t_List.Length > 265)
                Assert.That(tasksList.t_List[265].answer(), Is.EqualTo("1096883702440585"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_267_test()
        {
            if (tasksList.t_List.Length > 266)
                Assert.That(tasksList.t_List[266].answer(), Is.EqualTo("0.999992836187"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_268_test()
        {
            if (tasksList.t_List.Length > 267)
                Assert.That(tasksList.t_List[267].answer(), Is.EqualTo("785478606870985"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_269_test()
        {
            if (tasksList.t_List.Length > 268)
                Assert.That(tasksList.t_List[268].answer(), Is.EqualTo("1311109198529286"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_270_test()
        {
            if (tasksList.t_List.Length > 269)
                Assert.That(tasksList.t_List[269].answer(), Is.EqualTo("82282080"));
            else
                Assert.Ignore();
        }
    }
}
