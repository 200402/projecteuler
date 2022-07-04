namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_151_160
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_151_test()
        {
            if (tasksList.t_List.Length > 150)
                Assert.That(tasksList.t_List[150].answer(), Is.EqualTo("0.464399"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_152_test()
        {
            if (tasksList.t_List.Length > 151)
                Assert.That(tasksList.t_List[151].answer(), Is.EqualTo("301"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_153_test()
        {
            if (tasksList.t_List.Length > 152)
                Assert.That(tasksList.t_List[152].answer(), Is.EqualTo("17971254122360635"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_154_test()
        {
            if (tasksList.t_List.Length > 153)
                Assert.That(tasksList.t_List[153].answer(), Is.EqualTo("479742450"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_155_test()
        {
            if (tasksList.t_List.Length > 154)
                Assert.That(tasksList.t_List[154].answer(), Is.EqualTo("3857447"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_156_test()
        {
            if (tasksList.t_List.Length > 155)
                Assert.That(tasksList.t_List[155].answer(), Is.EqualTo("21295121502550"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_157_test()
        {
            if (tasksList.t_List.Length > 156)
                Assert.That(tasksList.t_List[156].answer(), Is.EqualTo("53490"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_158_test()
        {
            if (tasksList.t_List.Length > 157)
                Assert.That(tasksList.t_List[157].answer(), Is.EqualTo("409511334375"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_159_test()
        {
            if (tasksList.t_List.Length > 158)
                Assert.That(tasksList.t_List[158].answer(), Is.EqualTo("14489159"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_160_test()
        {
            if (tasksList.t_List.Length > 159)
                Assert.That(tasksList.t_List[159].answer(), Is.EqualTo("16576"));
            else
                Assert.Ignore();
        }
    }
}
