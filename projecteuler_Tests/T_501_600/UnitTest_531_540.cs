namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_531_540
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_531_test()
        {
            if (tasksList.t_List.Length > 530)
                Assert.That(tasksList.t_List[530].answer(), Is.EqualTo("4515432351156203105"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_532_test()
        {
            if (tasksList.t_List.Length > 531)
                Assert.That(tasksList.t_List[531].answer(), Is.EqualTo("827306.56"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_533_test()
        {
            if (tasksList.t_List.Length > 532)
                Assert.That(tasksList.t_List[532].answer(), Is.EqualTo("789453601"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_534_test()
        {
            if (tasksList.t_List.Length > 533)
                Assert.That(tasksList.t_List[533].answer(), Is.EqualTo("11726115562784664"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_535_test()
        {
            if (tasksList.t_List.Length > 534)
                Assert.That(tasksList.t_List[534].answer(), Is.EqualTo("611778217"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_536_test()
        {
            if (tasksList.t_List.Length > 535)
                Assert.That(tasksList.t_List[535].answer(), Is.EqualTo("3557005261906288"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_537_test()
        {
            if (tasksList.t_List.Length > 536)
                Assert.That(tasksList.t_List[536].answer(), Is.EqualTo("779429131"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_538_test()
        {
            if (tasksList.t_List.Length > 537)
                Assert.That(tasksList.t_List[537].answer(), Is.EqualTo("22472871503401097"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_539_test()
        {
            if (tasksList.t_List.Length > 538)
                Assert.That(tasksList.t_List[538].answer(), Is.EqualTo("426334056"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_540_test()
        {
            if (tasksList.t_List.Length > 539)
                Assert.That(tasksList.t_List[539].answer(), Is.EqualTo("500000000002845"));
            else
                Assert.Ignore();
        }
    }
}
