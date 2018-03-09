local transform;
local gameObject;

MainUIPanel = {};
local this = MainUIPanel;

--启动事件--
function MainUIPanel.Awake(obj)
	gameObject = obj;
	transform = obj.transform;

	this.InitPanel();
	logWarn("Awake lua--->>"..gameObject.name);
end

--初始化面板--
function MainUIPanel.InitPanel()
	this.btnClose = transform:FindChild("Button_Close").gameObject;
	this.btnShowTips = transform:FindChild("Button_ShowTips").gameObject;
	this.btnWhiteColor = transform:FindChild("Button_WhiteColor").gameObject;
	this.btnBlueColor = transform:FindChild("Button_BlueColor").gameObject;

	this.label_title= transform:FindChild("Label_Title").gameObject:GetComponent('UILabel');
	this.label_content= transform:FindChild("Label_Content").gameObject:GetComponent('UILabel');
	this.slider_progress= transform:FindChild("Slider_Progress").gameObject:GetComponent('UISlider');
	this.grid_dot= transform:FindChild("DotGrid").gameObject:GetComponent('UIGrid');


	this.dotItem =transform:Find("DotGrid/DotItem").gameObject;

end

--单击事件--
function MainUIPanel.OnDestroy()
	logWarn("OnDestroy---->>>");
end

