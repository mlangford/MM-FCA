Imports System.Windows.Forms
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.Geodatabase

Public Class s3_frmDemandDetails

#Region "formControl"

    Private m_configObj As configParams

    'Handles passing of the configObject through the forms
    Public Property configObj() As configParams
        Get
            Return m_configObj
        End Get
        Set(ByVal value As configParams)
            m_configObj = value
        End Set
    End Property

    Public Sub New(ByRef cObject As configParams)
        MyBase.New()
        'sets class level variable to the passed user object  
        configObj = cObject
        InitializeComponent()
    End Sub

    Private Sub btn3_Prev_Click(sender As System.Object, e As System.EventArgs) Handles btn3_Prev.Click

        'reset demand details to their initial defaults
        configObj.DemandLayerIndexCar = -1
        configObj.DemandVolumeFieldCar = -1
        configObj.DemandLayerIndexBus = -1
        configObj.DemandVolumeFieldBus = -1
        configObj.DemandExtraField = -1

        'redisplay the previous form
        Dim p_s2frmSupplyDetails As New s2_frmSupplyDetails(configObj)
        p_s2frmSupplyDetails.Location = Me.Location
        p_s2frmSupplyDetails.Show()
        Me.Dispose()

    End Sub

    Private Sub btn3Next_Click(sender As System.Object, e As System.EventArgs) Handles btn3Next.Click

        Dim list_item As layerItem

        'store the CAR demand points layer's map index in the configObj
        list_item = m_Pointlayers(cboDemandPointsLayerCar.SelectedIndex)
        configObj.DemandLayerIndexCar = list_item.position
        'store the BUS demand points layer's map index in the configObj
        list_item = m_Pointlayers(cboDemandPointsLayerBus.SelectedIndex)
        configObj.DemandLayerIndexBus = list_item.position

        'store the CAR demand volume field index in the configObj
        list_item = m_fieldlistCar(cboDemandFieldCar.SelectedIndex)
        configObj.DemandVolumeFieldCar = list_item.position
        'store the BUS demand volume field index in the configObj
        list_item = m_fieldlistCar(cboDemandFieldBus.SelectedIndex)
        configObj.DemandVolumeFieldBus = list_item.position

        'store the demand layer Extra Field index in the configObj
        configObj.DemandExtraField = cboDemandIDField.SelectedIndex

        'display next form
        Dim p_s4frmParameters As New s4_frmParameters(configObj)
        p_s4frmParameters.Location = Me.Location
        p_s4frmParameters.Show()
        Me.Dispose()

    End Sub

#End Region

#Region "globals"

    'List of point-data layer names and their map index positions
    Dim m_Pointlayers As List(Of layerItem)

    'List of field names that could be used as a demand volume
    Dim m_fieldlistCar As List(Of layerItem)
    Dim m_fieldlistBus As List(Of layerItem)
    Dim m_fieldlistXID As List(Of layerItem)

    'Flags to prevent the field names warning on initial form load
    Dim firstCar As Boolean = True
    Dim firstBus As Boolean = True

#End Region

#Region "formLoad configuration"

    Private Sub s3_frmDemandDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'get a list of point layers in the current map (excluding the CAR supply points)
        m_Pointlayers = fcaUtilities.getPointlayers(configObj.SupplyLayerIndexCar)

        If m_Pointlayers.Count > 0 Then
            'populate the layer selection dropdowns with this list
            For Each list_item As layerItem In m_Pointlayers
                cboDemandPointsLayerCar.Items.Add(list_item.title)
            Next
            'set selected item as the first item
            cboDemandPointsLayerCar.SelectedIndex = 0
            btn3Next.Enabled = True
        Else
            'if no point data layers were present, issue a warning message
            MessageBox.Show("**Error** - there are no further map layers containing point objects", _
                                            "**ERROR**", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn3Next.Enabled = False
        End If

        'get a list of point layers in the current map (excluding the BUS supply points)
        m_Pointlayers = fcaUtilities.getPointlayers(configObj.SupplyLayerIndexBus)

        If m_Pointlayers.Count > 0 Then
            'populate the layer selection dropdowns with this list
            For Each list_item As layerItem In m_Pointlayers
                cboDemandPointsLayerBus.Items.Add(list_item.title)
            Next
            'set selected item as the first item
            cboDemandPointsLayerBus.SelectedIndex = 0
            btn3Next.Enabled = True
        Else
            'if no point data layer present issue warning message
            MessageBox.Show("**Error** - no layers containing point objects identified", _
                                            "**ERROR**", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn3Next.Enabled = False
        End If

    End Sub

#End Region

#Region "user selects demand points layer"

    'use selects CAR demand volume field
    Private Sub cboDemandPointsLayerCar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) _
        Handles cboDemandPointsLayerCar.SelectedIndexChanged

        'get list of field names in the demand point layer that might be a demand volume
        Dim layer_item As layerItem = m_Pointlayers(cboDemandPointsLayerCar.SelectedIndex)
        m_fieldlistCar = fcaUtilities.getDatafields2(layer_item.position)

        If m_fieldlistCar.Count > 0 Then
            'populate the dropdown with the field names
            cboDemandFieldCar.Items.Clear()
            For Each field_item As layerItem In m_fieldlistCar
                cboDemandFieldCar.Items.Add(field_item.title)
            Next
            'set the field selection initially to the first item
            cboDemandFieldCar.SelectedIndex = 0
            btn3Next.Enabled = True
        Else
            'if no suitable fields are available, issue a warning message
            If Not firstCar Then
                MessageBox.Show("Selected demand layer has no numeric fields" & Environment.NewLine _
                                               & "     but one is needed for the demand volume information", _
                                                   "**Information**", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btn3Next.Enabled = False
            End If
            firstCar = False
        End If

        'get list of all field names in the demand point layer 
        m_fieldlistXID = fcaUtilities.getDatafields3(layer_item.position)

        If m_fieldlistXID.Count > 0 Then
            'populate the dropdown with the field names
            cboDemandIDField.Items.Clear()
            For Each field_item As layerItem In m_fieldlistXID
                cboDemandIDField.Items.Add(field_item.title)
            Next
            'set the field selection initially to the first item
            cboDemandIDField.SelectedIndex = 0
        End If

    End Sub

    'use selects BUS demand volume field
    Private Sub cboDemandPointsLayerBus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) _
        Handles cboDemandPointsLayerBus.SelectedIndexChanged

        'get list of field names in the demand point layer that might be a demand volume
        Dim layer_item As layerItem = m_Pointlayers(cboDemandPointsLayerBus.SelectedIndex)
        m_fieldlistBus = fcaUtilities.getDatafields2(layer_item.position)

        cboDemandFieldBus.Items.Clear()
        If m_fieldlistBus.Count > 0 Then
            'populate the dropdowns with the field names
            For Each field_item As layerItem In m_fieldlistBus
                cboDemandFieldBus.Items.Add(field_item.title)
            Next
            'set the field selection initially to the first item
            cboDemandFieldBus.SelectedIndex = 0
            btn3Next.Enabled = True
        Else
            'if no suitable fields are available, issue a warning message
            If Not firstBus Then
                MessageBox.Show("Selected demand layer has no numeric fields" & Environment.NewLine _
                                               & "     but one is needed for the demand volume information", _
                                                   "**Information**", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btn3Next.Enabled = False
            End If
            firstBus = False
        End If

    End Sub

#End Region

    'Private Sub cboDemandFieldCar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDemandFieldCar.SelectedIndexChanged
    '    Dim list_item As layerItem = m_fieldlistCar(cboDemandFieldCar.SelectedIndex)
    '    MessageBox.Show(list_item.position)
    'End Sub

    'Private Sub cboDemandFieldBus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDemandFieldBus.SelectedIndexChanged
    '    Dim list_item As layerItem = m_fieldlistBus(cboDemandFieldBus.SelectedIndex)
    '    MessageBox.Show(list_item.position)
    'End Sub

End Class