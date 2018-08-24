﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
#if UNITY_EDITOR
using MyAttribute;
#endif
namespace PokemonBattele
{
    /// <summary>
    /// 特性
    /// </summary>
    [Serializable]
    public class Ability
    {
        [SerializeField]
        #if UNITY_EDITOR    
        [FieldLabel("特性名称")]
        #endif
        public AbilityType abilityType;

        [SerializeField]
#if UNITY_EDITOR
        [FieldLabel("描述")]
#endif
        [TextArea]
        public string description="";
        

    }
    public class AbilityType_EnumComare : IEqualityComparer<AbilityType>
    {
        public bool Equals(AbilityType x, AbilityType y)
        {
            return x == y;
        }

        public int GetHashCode(AbilityType obj)
        {
            return (int)obj;
        }
    }
    public enum AbilityType
    {
        NULL=0
        ,恶臭
        ,降雨
        ,加速
        ,战斗盔甲
        ,结实
        ,湿气
        ,柔软
        ,沙隐
        ,静电
        ,蓄电
        ,储水
        ,迟钝
        ,无关天气
        ,复眼
        ,不眠
        ,变色
        ,免疫
        ,引火
        ,鳞粉
        ,我行我素
        ,吸盘
        ,威吓
        ,踩影
        ,粗糙皮肤
        ,神奇守护
        ,飘浮
        ,孢子
        ,同步
        ,恒净之躯
        ,自然回复
        ,避雷针
        ,天恩
        ,悠游自如
        ,叶绿素
        ,发光
        ,复制
        ,大力士
        ,毒刺
        ,精神力
        ,熔岩铠甲
        ,水幕
        ,磁力
        ,隔音
        ,雨盘
        ,扬沙
        ,压迫感
        ,厚脂肪
        ,早起
        ,火焰之躯
        ,逃跑
        ,锐利目光
        ,怪力钳
        ,捡拾
        ,懒惰
        ,活力
        ,迷人之躯
        ,正电
        ,负电
        ,阴晴不定
        ,黏着
        ,蜕皮
        ,毅力
        ,神奇鳞片
        ,污泥浆
        ,茂盛
        ,猛火
        ,激流
        ,虫之预感
        ,坚硬脑袋
        ,日照
        ,沙穴
        ,干劲
        ,白色烟雾
        ,瑜伽之力
        ,硬壳盔甲
        ,气闸
        ,蹒跚
        ,电气引擎
        ,斗争心
        ,不屈之心
        ,雪隐
        ,贪吃鬼
        ,愤怒穴位
        ,轻装
        ,耐热
        ,单纯
        ,干燥皮肤
        ,下载
        ,铁拳
        ,毒疗
        ,适应力
        ,连续攻击
        ,湿润之躯
        ,太阳之力
        ,飞毛腿
        ,一般皮肤
        ,狙击手
        ,魔法防守
        ,无防守
        ,慢出
        ,技术高手
        ,叶子防守
        ,笨拙
        ,破格
        ,超幸运
        ,引爆
        ,危险预知
        ,预知梦
        ,纯朴
        ,有色眼镜
        ,过滤
        ,慢启动
        ,胆量
        ,引水
        ,冰冻之躯
        ,坚硬岩石
        ,降雪
        ,采蜜
        ,察觉
        ,舍身
        ,多属性
        ,花之礼
        ,梦魇
        ,顺手牵羊
        ,强行
        ,唱反调
        ,紧张感
        ,不服输
        ,软弱
        ,诅咒之躯
        ,治愈之心
        ,友情防守
        ,碎裂铠甲
        ,重金属
        ,轻金属
        ,多重鳞片
        ,中毒激升
        ,受热激升
        ,收获
        ,心灵感应
        ,心情不定
        ,防尘
        ,毒手
        ,再生力
        ,健壮胸肌
        ,拨沙
        ,奇迹皮肤
        ,分析
        ,幻觉
        ,变身者
        ,穿透
        ,木乃伊
        ,自信过度
        ,正义之心
        ,胆怯
        ,魔法镜
        ,食草
        ,恶作剧之心
        ,沙之力
        ,铁刺
        ,达摩模式
        ,胜利之星
        ,涡轮火焰
        ,兆级电压
        ,芳香幕
        ,花幕
        ,颊囊
        ,变幻自如
        ,毛皮大衣
        ,魔术师
        ,防弹
        ,好胜
        ,强壮之颚
        ,冰冻皮肤
        ,甜幕
        ,战斗切换
        ,疾风之翼
        ,超级发射器
        ,草之毛皮
        ,共生
        ,硬爪
        ,妖精皮肤
        ,黏滑
        ,飞行皮肤
        ,亲子爱
        ,暗黑气场
        ,妖精气场
        ,气场破坏
        ,始源之海
        ,终结之地
        ,德尔塔气流
        ,持久力
        ,跃跃欲逃
        ,危险回避
        ,遇水凝固
        ,不仁不义
        ,界限盾壳
        ,蹲守
        ,水泡
        ,钢能力者
        ,怒火冲天
        ,拨雪
        ,远隔
        ,湿润之声
        ,先行治疗
        ,电气皮肤
        ,冲浪之尾
        ,鱼群
        ,画皮
        ,牵绊变身
        ,群聚变形
        ,腐蚀
        ,绝对睡眠
        ,女王的威严
        ,飞出的内在物
        ,舞者
        ,蓄电池
        ,毛茸茸
        ,鲜艳之躯
        ,魂心
        ,卷发
        ,接球手
        ,化学之力
        ,异兽提升
        ,ＡＲ系统
        ,电气制造者
        ,精神制造者
        ,薄雾制造者
        ,青草制造者
        ,金属防护
        ,幻影防守
        ,棱镜装甲
        ,脑核之力
        }
}
