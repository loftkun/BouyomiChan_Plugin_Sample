using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FNF.BouyomiChanApp;

namespace Plugin_Sample
{
    public class Plugin_Sample : IPlugin
    {

        #region IPlugin メンバー の実装

        /// <summary>
        /// 棒読みちゃん本体の起動時か、
        /// プラグインを有効にしたタイミングで呼ばれる
        /// </summary>
        public void Begin()
        {
            //このプラグインの設定ファイルから設定値を読み込み
            //⇒まだ実装していません。

            //棒読みちゃん本体の画面にこのプラグインのボタンを追加
            //⇒まだ実装していません。

            return;
        }

        /// <summary>
        /// プラグインの備考
        /// </summary>
        public string Caption
        {
            get { return "何もしないプラグインです。"; }
        }

        /// <summary>
        /// 棒読みちゃん本体の終了時か、
        /// プラグインを無効にしたタイミングで呼ばれる
        /// </summary>
        public void End()
        {
            //設定値をこのプラグインの設定フィルに書き込み
            //⇒まだ実装していません。

            //棒読みちゃん本体の画面からこのプラグインのボタンを削除
            //⇒まだ実装していません。

            return;
        }

        /// <summary>
        /// プラグインの名称
        /// </summary>
        public string Name
        {
            get { return "サンプルプラグイン"; }
        }

        /// <summary>
        /// プラグインの設定画面管理クラス
        /// </summary>
        public FNF.XmlSerializerSetting.ISettingFormData SettingFormData
        {
            //⇒まだ実装していません。
            get { return null; }
        }

        /// <summary>
        /// プラグインのバージョン
        /// </summary>
        public string Version
        {
            //公式プラグイン(クリップボード監視、Skype読み上げetc)の
            //バージョン表記に合わせて、
            //"西暦/月/日付版"としておくと統一感がでるでしょう。
            get { return "2012/02/26版"; }
        }
        #endregion
    }
}
