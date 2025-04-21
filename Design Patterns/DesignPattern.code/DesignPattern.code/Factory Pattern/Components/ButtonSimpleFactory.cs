namespace DesignPattern.code.Factory_Pattern.Components
{
    public class ButtonSimpleFactory
    {
        public IButton GetButton(string buttonType)
        {

            switch (buttonType.ToUpper())
            {
                case "MAC":
                    return new MacButton();

                case "WINDOW":
                    return new WinButton();

                default:
                    return new NullButton();
            }
        }
    }
}
