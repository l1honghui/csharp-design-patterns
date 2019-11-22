using System.Collections.Generic;

namespace facade
{
    public abstract class DwarvenMineWorker
    {
        public void GoToSleep()
        {
            System.Console.WriteLine("{0} goes to sleep.", Name());
        }

        public void WakeUp()
        {
            System.Console.WriteLine("{0} wakes up.", Name());
        }

        public void GoHome()
        {
            System.Console.WriteLine("{0} goes home.", Name());
        }

        public void GoToMine()
        {
            System.Console.WriteLine("{0} goes to the mine.", Name());
        }

        private void Action(ActionEnum actionEnum)
        {
            switch (actionEnum)
            {
                case ActionEnum.GoToSleep:
                    GoToSleep();
                    break;
                case ActionEnum.WakeUp:
                    WakeUp();
                    break;
                case ActionEnum.GoHome:
                    GoHome();
                    break;
                case ActionEnum.GoToMine:
                    GoToMine();
                    break;
                case ActionEnum.Work:
                    Work();
                    break;
                default:
                    System.Console.WriteLine("Undefined action");
                    break;
            }
        }

        /**
         * Perform actions.
         */
        public void Action(List<ActionEnum> actions)
        {
            foreach (ActionEnum action in actions)
            {
                Action(action);
            }
        }

        public abstract void Work();

        public abstract string Name();
    }

    public enum ActionEnum
    {
        GoToSleep,
        WakeUp,
        GoHome,
        GoToMine,
        Work
    }
}