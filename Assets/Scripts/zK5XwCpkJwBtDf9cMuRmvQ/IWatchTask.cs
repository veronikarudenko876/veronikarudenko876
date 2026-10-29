/// <summary>
/// The one interface in this project, and it earns its place: the watch director drives
/// three unrelated dockside activities through the same five calls, so it never needs to
/// know which one is running.
/// </summary>
public interface _0x4b8f06f9
{
    /// <summary>Lay the activity out on the board from the seeded layout.</summary>
    void Begin(_0x3ea7f588 _0x490efcfe, _0x92b1008d _0x14996d51, _0xaed87db8 _0xb5fb20ba, System.Random _0xb0dacc97);
    /// <summary>Advance any timed part of the activity.</summary>
    void Advance(float delta);
    /// <summary>A berth was tapped. A wrong tap never costs anything.</summary>
    void BerthTapped(int _0x8fc87fbf);
    /// <summary>The crew resolves one step for an idle keeper (the harbourmaster assist).
    /// Returns the berth the crew lit, or -1 if it could not help.</summary>
    int AssistOneStep();
    /// <summary>Take the activity off the board before the next one starts.</summary>
    void Finish();
    int StepsDone { get; }

    int StepsNeeded { get; }

    /// <summary>The instruction shown on the task card. Line breaks are explicit.</summary>
    string Instruction { get; }

    /// <summary>The crest the card must show, or -1 when this activity shows none.</summary>
    int ShownCrest { get; }
}