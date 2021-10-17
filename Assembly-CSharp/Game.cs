using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Game : KMonoBehaviour
{
    public static Game Instance { get; private set; }
    [NonSerialized]
    public Player LocalPlayer;
    [SerializeField]
    public TextAsset maleNamesFile;
    [SerializeField]
    public TextAsset femaleNamesFile;
    [NonSerialized]
    public World world;
    [NonSerialized]
    public CircuitManager circuitManager;
    [NonSerialized]
    public EnergySim energySim;
    [NonSerialized]
    public LogicCircuitManager logicCircuitManager;
    private GameScreenManager screenMgr;
    public UtilityNetworkManager<FlowUtilityNetwork, Vent> gasConduitSystem;
    public UtilityNetworkManager<FlowUtilityNetwork, Vent> liquidConduitSystem;
    public UtilityNetworkManager<ElectricalUtilityNetwork, Wire> electricalConduitSystem;
    public UtilityNetworkManager<LogicCircuitNetwork, LogicWire> logicCircuitSystem;
    public UtilityNetworkTubesManager travelTubeSystem;
    public UtilityNetworkManager<FlowUtilityNetwork, SolidConduit> solidConduitSystem;
    public ConduitFlow gasConduitFlow;
    public ConduitFlow liquidConduitFlow;
    public SolidConduitFlow solidConduitFlow;
    public Accumulators accumulators;
    public PlantElementAbsorbers plantElementAbsorbers;
    public Game.TemperatureOverlayModes temperatureOverlayMode;
    public bool showExpandedTemperatures;
    public List<Tag> tileOverlayFilters = new List<Tag>();
    public bool showGasConduitDisease;
    public bool showLiquidConduitDisease;
    public ConduitFlowVisualizer gasFlowVisualizer;
    public ConduitFlowVisualizer liquidFlowVisualizer;
    public SolidConduitFlowVisualizer solidFlowVisualizer;
    public ConduitTemperatureManager conduitTemperatureManager;
    public ConduitDiseaseManager conduitDiseaseManager;
    public MingleCellTracker mingleCellTracker;
    public enum TemperatureOverlayModes
    {
        AbsoluteTemperature,
        AdaptiveTemperature,
        HeatFlow,
        StateChange,
    }
}
