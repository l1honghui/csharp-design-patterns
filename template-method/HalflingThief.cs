namespace template_method
{
    public class HalflingThief
    {
        private StealingMethod _method;

        public HalflingThief(StealingMethod method) {
            this._method = method;
        }

        public void Steal() {
            _method.Steal();
        }

        public void ChangeMethod(StealingMethod method) {
            this._method = method;
        }
    }
}