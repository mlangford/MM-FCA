Public Class configParams

    Private m_NWlayerindexCar As Integer = -1
    Private m_NWimpedanceCar As String = ""
    Private m_NWlayerindexBus As Integer = -1
    Private m_NWimpedanceBus As String = ""

    Private m_NWdefCutOffCar As Double = 0.0
    Private m_NWdefCutOffBus As Double = 0.0

    Private m_NWscale As Double = 1.0

    Private m_SupplyLayerIndexCar As Integer = -1
    Private m_SupplySelectedCar As Boolean = False
    Private m_SupplyVolumeFieldCar As Integer = -1
    Private m_SupplyLayerIndexBus As Integer = -1
    Private m_SupplySelectedBus As Boolean = False
    Private m_SupplyVolumeFieldBus As Integer = -1

    Private m_DemandLayerIndexCar As Integer = -1
    Private m_DemandSelectedCar As Boolean = False
    Private m_DemandVolumeFieldCar As Integer = -1
    Private m_DemandLayerIndexBus As Integer = -1
    Private m_DemandSelectedBus As Boolean = False
    Private m_DemandVolumeFieldBus As Integer = -1

    Private m_DemandExtraField As Integer = -1

    Private m_ResultsLoc As String = ""
    Private m_Filename As String = ""

    Private m_filter As decayType = decayType.Classic
    Private m_gauss As Double = 0.0
    Private m_bwpass As Double = 0.0
    Private m_bwpower As Double = 0.0

    Public Sub New()
        MyBase.New()
    End Sub

    Public Property NWlayerindexCar() As Integer
        Get
            Return m_NWlayerindexCar
        End Get
        Set(ByVal value As Integer)
            m_NWlayerindexCar = value
        End Set
    End Property

    Public Property NWlayerindexBus() As Integer
        Get
            Return m_NWlayerindexBus
        End Get
        Set(ByVal value As Integer)
            m_NWlayerindexBus = value
        End Set
    End Property

    Public Property NWimpedanceCar() As String
        Get
            Return m_NWimpedanceCar
        End Get
        Set(ByVal value As String)
            m_NWimpedanceCar = value
        End Set
    End Property

    Public Property NWimpedanceBus As String
        Get
            Return m_NWimpedanceBus
        End Get
        Set(ByVal value As String)
            m_NWimpedanceBus = value
        End Set
    End Property

    Public Property NWdefCutOffCar() As Double
        Get
            Return m_NWdefCutOffCar
        End Get
        Set(ByVal value As Double)
            m_NWdefCutOffCar = value
        End Set
    End Property

    Public Property NWdefCutOffBus() As Double
        Get
            Return m_NWdefCutOffBus
        End Get
        Set(ByVal value As Double)
            m_NWdefCutOffBus = value
        End Set
    End Property

    Public Property NWscale() As Double
        Get
            Return m_NWscale
        End Get
        Set(ByVal value As Double)
            m_NWscale = value
        End Set
    End Property

    Public Property SupplyLayerIndexCar() As Integer
        Get
            Return m_SupplyLayerIndexCar
        End Get
        Set(ByVal value As Integer)
            m_SupplyLayerIndexCar = value
        End Set
    End Property

    Public Property SupplyLayerIndexBus() As Integer
        Get
            Return m_SupplyLayerIndexBus
        End Get
        Set(ByVal value As Integer)
            m_SupplyLayerIndexBus = value
        End Set
    End Property

    Public Property SupplySelectedCar() As Boolean
        Get
            Return m_SupplySelectedCar
        End Get
        Set(ByVal value As Boolean)
            m_SupplySelectedCar = value
        End Set
    End Property

    Public Property SupplySelectedBus() As Boolean
        Get
            Return m_SupplySelectedBus
        End Get
        Set(ByVal value As Boolean)
            m_SupplySelectedBus = value
        End Set
    End Property

    Public Property SupplyVolumeFieldCar() As Integer
        Get
            Return m_SupplyVolumeFieldCar
        End Get
        Set(ByVal value As Integer)
            m_SupplyVolumeFieldCar = value
        End Set
    End Property

    Public Property SupplyVolumeFieldBus() As Integer
        Get
            Return m_SupplyVolumeFieldBus
        End Get
        Set(ByVal value As Integer)
            m_SupplyVolumeFieldBus = value
        End Set
    End Property

    Public Property DemandLayerIndexCar() As Integer
        Get
            Return m_DemandLayerIndexCar
        End Get
        Set(ByVal value As Integer)
            m_DemandLayerIndexCar = value
        End Set
    End Property

    Public Property DemandLayerIndexBus() As Integer
        Get
            Return m_DemandLayerIndexBus
        End Get
        Set(ByVal value As Integer)
            m_DemandLayerIndexBus = value
        End Set
    End Property

    Public Property DemandSelectedCar() As Boolean
        Get
            Return m_DemandSelectedCar
        End Get
        Set(ByVal value As Boolean)
            m_DemandSelectedCar = value
        End Set
    End Property

    Public Property DemandSelectedBus() As Boolean
        Get
            Return m_DemandSelectedBus
        End Get
        Set(ByVal value As Boolean)
            m_DemandSelectedBus = value
        End Set
    End Property

    Public Property DemandVolumeFieldCar() As Integer
        Get
            Return m_DemandVolumeFieldCar
        End Get
        Set(ByVal value As Integer)
            m_DemandVolumeFieldCar = value
        End Set
    End Property

    Public Property DemandExtraField() As Integer
        Get
            Return m_DemandExtraField
        End Get
        Set(ByVal value As Integer)
            m_DemandExtraField = value
        End Set
    End Property

    Public Property DemandVolumeFieldBus() As Integer
        Get
            Return m_DemandVolumeFieldBus
        End Get
        Set(ByVal value As Integer)
            m_DemandVolumeFieldBus = value
        End Set
    End Property

    Public Property gaussian_bw As Double
        Get
            Return m_gauss
        End Get
        Set(ByVal value As Double)
            m_gauss = value
        End Set
    End Property

    Public Property butterworth_pwr As Double
        Get
            Return m_bwpower
        End Get
        Set(ByVal value As Double)
            m_bwpower = value
        End Set
    End Property

    Public Property butterworth_bw As Double
        Get
            Return m_bwpass
        End Get
        Set(ByVal value As Double)
            m_bwpass = value
        End Set
    End Property

    Public Property filter As Integer
        Get
            Return m_filter
        End Get
        Set(ByVal value As Integer)
            m_filter = value
        End Set
    End Property

    Public Property ResultsLocation As String
        Get
            Return m_ResultsLoc
        End Get
        Set(ByVal value As String)
            m_ResultsLoc = value
        End Set
    End Property

    Public Property Filename As String
        Get
            Return m_Filename
        End Get
        Set(ByVal value As String)
            m_Filename = value
        End Set
    End Property

End Class

