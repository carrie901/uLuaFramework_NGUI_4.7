require "Common/define"
require "Controller/PromptCtrl"
require "Controller/MessageCtrl"
require "Controller/MainUICtrl"

CtrlManager = {};
local this = CtrlManager;
local ctrlList = {};    --控制器列表--

function CtrlManager.Init()
    print("控制器列表 CtrlManager.Init----->>>");
    ctrlList[CtrlNames.Prompt] = PromptCtrl.New();
    ctrlList[CtrlNames.Message] = MessageCtrl.New();
    ctrlList[CtrlNames.MainUI] = MainUICtrl.New();

    return this;
end

--添加控制器--
function CtrlManager.AddCtrl(ctrlName,ctrlObj)
    ctrlList[ctrlName] = ctrlObj;
end

--获取控制器--
function CtrlManager.GetCtrl(ctrlName)
    print("CtrlManager.GetCtrl---->>> ctrlName: " .. ctrlName );
    return ctrlList[ctrlName];
end

--移除控制器--
function CtrlManager.RemoveCtrl(ctrlName)
    ctrlList[ctrlName] = nil;
end

--关闭控制器--
function CtrlManager.Close()
    logWarn('CtrlManager.Close---->>>');
end