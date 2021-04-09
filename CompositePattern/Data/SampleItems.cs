using CompositePattern.ToDo;

namespace CompositePattern.Data
{
    public static class SampleItems
    {
        public const decimal PayRate = 35;
        public const decimal CallRate = 2;

        public static readonly WorkItem DesignGui = new
        (
            name: nameof(DesignGui),
            description: "Think about making it pretty",
            hours: 10,
            estimatedHours: 12
        );

        public static readonly WorkItem ProgramGui = new
        (
            name: nameof(ProgramGui),
            description: "Do some Angular stuff",
            hours: 20,
            estimatedHours: 15
        );

        public static readonly CommunicationItem CallNewYork = new
        (
            name: nameof(CallNewYork),
            description: "Telephone Donald in the Big Apple",
            hours: 0.5
        );

        public static readonly PurchaseItem BuyCoffee = new
        (
            name: nameof(BuyCoffee),
            description: "Get a latte",
            cost: 4.5m,
            supplier: "Fortnum and Mason"
        );

        public static readonly WorkItem DesignApi = new
        (
            name: nameof(DesignApi),
            description: "Design the WebAPI service",
            hours: 15,
            estimatedHours: 15
        );

        public static readonly WorkItem ProgramApi = new
        (
            name: nameof(ProgramApi),
            description: "Program the WebAPI service",
            hours: 35,
            estimatedHours: 15
        );


        public static readonly PurchaseItem BuyBook = new
        (
            name: nameof(BuyBook),
            description: "Buy a book on how to program WebAPI",
            cost: 35m,
            supplier: "Waterstones"
        );

        public static readonly WorkItem ReProgramApi = new
        (
            name: nameof(ReProgramApi),
            description: "Fix the WebAPI service",
            hours: 20,
            estimatedHours: 15
        );

        public static readonly CommunicationItem CallNewYorkAgain = new
        (
            name: nameof(CallNewYorkAgain),
            description: "Explain the delays to Donald",
            hours: 2
        );

        public static readonly PurchaseItem BuyNewServer = new
        (
            name: nameof(BuyNewServer),
            description: "Go and get some better hardware",
            cost: 5600m,
            supplier: "Dell"
        );
    }
}
