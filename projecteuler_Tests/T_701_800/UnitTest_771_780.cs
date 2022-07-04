namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_771_780
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_771_test()
        {
            if (tasksList.t_List.Length > 770)
                Assert.That(tasksList.t_List[770].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_772_test()
        {
            if (tasksList.t_List.Length > 771)
                Assert.That(tasksList.t_List[771].answer(), Is.EqualTo("83985379"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_773_test()
        {
            if (tasksList.t_List.Length > 772)
                Assert.That(tasksList.t_List[772].answer(), Is.EqualTo("556206950"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_774_test()
        {
            if (tasksList.t_List.Length > 773)
                Assert.That(tasksList.t_List[773].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_775_test()
        {
            if (tasksList.t_List.Length > 774)
                Assert.That(tasksList.t_List[774].answer(), Is.EqualTo("946791106"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_776_test()
        {
            if (tasksList.t_List.Length > 775)
                Assert.That(tasksList.t_List[775].answer(), Is.EqualTo("9.627509725002e33"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_777_test()
        {
            if (tasksList.t_List.Length > 776)
                Assert.That(tasksList.t_List[776].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_778_test()
        {
            if (tasksList.t_List.Length > 777)
                Assert.That(tasksList.t_List[777].answer(), Is.EqualTo("146133880"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_779_test()
        {
            if (tasksList.t_List.Length > 778)
                Assert.That(tasksList.t_List[778].answer(), Is.EqualTo("0.547326103833"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_780_test()
        {
            if (tasksList.t_List.Length > 779)
                Assert.That(tasksList.t_List[779].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }
    }
}
