namespace Builder
{
    class BMWBuilder : CarBuilder
    {
        public BMWBuilder() : base("BMW")
        {
        }

        public override void BuildEngine()
        {
            Car.AddPart("a fancey V8 engine");
        }

        public override void BuildFrame()
        {
            Car.AddPart("5-door with metallic finish");
        }
    }
}