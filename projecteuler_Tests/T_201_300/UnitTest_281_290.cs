namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_281_290
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_281_test()
        {
            if (tasksList.t_List.Length > 280)
                Assert.That(tasksList.t_List[280].answer(), Is.EqualTo("1485776387445623"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_282_test()
        {
            if (tasksList.t_List.Length > 281)
                Assert.That(tasksList.t_List[281].answer(), Is.EqualTo("1098988351"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_283_test()
        {
            if (tasksList.t_List.Length > 282)
                Assert.That(tasksList.t_List[282].answer(), Is.EqualTo("28038042525570324"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_284_test()
        {
            if (tasksList.t_List.Length > 283)
                Assert.That(tasksList.t_List[283].answer(), Is.EqualTo("5a411d7b"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_285_test()
        {
            if (tasksList.t_List.Length > 284)
                Assert.That(tasksList.t_List[284].answer(), Is.EqualTo("157055.80999"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_286_test()
        {
            if (tasksList.t_List.Length > 285)
                Assert.That(tasksList.t_List[285].answer(), Is.EqualTo("52.6494571953"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_287_test()
        {
            if (tasksList.t_List.Length > 286)
                Assert.That(tasksList.t_List[286].answer(), Is.EqualTo("313135496"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_288_test()
        {
            if (tasksList.t_List.Length > 287)
                Assert.That(tasksList.t_List[287].answer(), Is.EqualTo("605857431263981935"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_289_test()
        {
            if (tasksList.t_List.Length > 288)
                Assert.That(tasksList.t_List[288].answer(), Is.EqualTo("6567944538"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_290_test()
        {
            if (tasksList.t_List.Length > 289)
                Assert.That(tasksList.t_List[289].answer(), Is.EqualTo("20444710234716473"));
            else
                Assert.Ignore();
        }
    }
}
