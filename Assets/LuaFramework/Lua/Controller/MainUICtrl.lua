require "Common/define"

MainUICtrl = {};
local this = MainUICtrl;

local Luabe;
local transform;
local gameObject;



--构建函数--
function MainUICtrl.New()
    logWarn("MainUICtrl.New--->>");
    return this;
end

function MainUICtrl.Awake()
    logWarn("MainUICtrl.Awake--->>");
    panelMgr:CreatePanel('MainUI',this.OnCreate);
end

--启动事件--
function MainUICtrl.OnCreate(obj)
    gameObject = obj;

    local panel = gameObject:GetComponent('UIPanel');
    --panel.depth = 10;	--设置纵深--

    Luabe = gameObject:GetComponent('LuaBehaviour');
    Luabe:AddClick(MainUIPanel.btnClose,this.OnClick);
    Luabe:AddClick(MainUIPanel.btnShowTips,this.OnClickShowTips);
    Luabe:AddClick(MainUIPanel.btnWhiteColor,this.OnClickWhiteColor);
    Luabe:AddClick(MainUIPanel.btnBlueColor,this.OnClickBlueColor);

    logWarn("Start lua--->>" .. gameObject.name);

    MainUIPanel.label_title.text = "MAINUI LUA TITLE"
    MainUIPanel.label_content.text = "关于性能优化的两条格言：\r\n规则 1：不要优化\r\n规则 2：还是不要优化（仅限专家）\r\n不要在缺乏恰当度量（measurements）时试图去优化软件。编程老手和菜鸟之间的区别不是说老手更善于洞察程序的性能瓶颈，而是老手知道他们并不善于此。\r\n做性能优化离不开度量。优化前度量，可知何处需要优化。优化后度量，可知「优化」是否确实改进了代码。";


    this.InitDotItems();
    this.PlaySliderTween();

end

function MainUICtrl.TestIconConfig(id)
    local i = tonumber(id);
    local co = IconConfig.Get(i);

    MainUIPanel.label_title.text = id .. "\r\n" .. co.Key;

end




--初始化小圆点
function MainUICtrl.InitDotItems()

    local grid = MainUIPanel.grid_dot;
    local parent = MainUIPanel.grid_dot.transform;
    local itemPrefab = MainUIPanel.dotItem;
    for i = 1,5 do
        local go = newObject(itemPrefab);
        go.name = tostring(i);
        go.transform.parent = parent;
        go.transform.localScale = Vector3.one;
        go.transform.localPosition = Vector3.zero;
        go:SetActive(true);
        Luabe:AddClick(go,this.OnItemClick);

        local goo = go.transform:Find('Label');
        goo:GetComponent('UILabel').text = i;
    end

    grid:Reposition();
    grid.repositionNow = true;

end

local slider_va = 0;
--执行slider 动画
function MainUICtrl.PlaySliderTween()
    slider_va = 0;
    MainUIPanel.slider_progress.value = slider_va;

    --this.TestCo();
    this.StartDelay();

end


--测试协同--

function MainUICtrl.TestCo()
    StartCoroutine(MainUICtrl.CoExample)
end

function MainUICtrl.CoExample()
    WaitForSeconds(1)
    print('WaitForSeconds end time: ' .. UnityEngine.Time.time)
    WaitForFixedUpdate()
    print('WaitForFixedUpdate end frameCount: ' .. UnityEngine.Time.frameCount)
    WaitForEndOfFrame()
    print('WaitForEndOfFrame end frameCount: ' .. UnityEngine.Time.frameCount)
    Yield(null)
    print('yield null end frameCount: ' .. UnityEngine.Time.frameCount)
    Yield(0)
    print('yield(0) end frameCime: ' .. UnityEngine.Time.frameCount)
    local www = UnityEngine.WWW('http://www.baidu.com')
    Yield(www)
    print('yield(www) end time: ' .. UnityEngine.Time.time)
    local s = tolua.tolstring(www.bytes)
    print(s:sub(1,128))
    print('coroutine over')

end

local coDelay = nil

function MainUICtrl.SliderTweenDelay()

    while slider_va < 1 do
        WaitForSeconds(1)

        slider_va = slider_va + 0.01;
        MainUIPanel.slider_progress.value = slider_va;

    end
end

function MainUICtrl.StartDelay()
    coDelay = StartCoroutine(this.SliderTweenDelay)
end

function MainUICtrl.StopDelay()
    StopCoroutine(coDelay)
    coDelay = nil
end



--滚动项单击事件--
function MainUICtrl.OnItemClick(go)
    log("MainUICtrl.OnItemClick : " .. go.name);
    this.TestIconConfig(go.name);

end



--单击事件--
function MainUICtrl.OnClick(go)
    destroy(gameObject);
end


--单击事件--
function MainUICtrl.OnClickShowTips(go)
    MainUIPanel.label_content.text = "当 Lua 想在表中插入一个新的键值而哈希数组已满时，Lua 会做一次重新哈希（rehash）。重新哈希的第一步是决定新的数组部分和哈希部分的大小。所以 Lua 遍历所有的项，并加以计数和分类，然后取一个使数组部分用量过半的最大的 2 的指数值，作为数组部分的大小。而哈希部分的大小则是一个容得下剩余项（即那些不适合放在数组部分的项）的最小的 2 的指数值。";
end


--单击事件--
function MainUICtrl.OnClickWhiteColor(go)
    MainUIPanel.label_content.color = Color.white;
end

--单击事件--
function MainUICtrl.OnClickBlueColor(go)
    MainUIPanel.label_content.color =  Color(0,65,154)  --Color.blue;
end


--关闭事件--
function MainUICtrl.Close()

    StopCoroutine(this.SliderTweenDelay)
    panelMgr:ClosePanel(CtrlNames.MainUI);
end