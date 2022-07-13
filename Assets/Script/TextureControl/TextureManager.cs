/**
* @file TextureManager.cs
* @brief 実行中の画像を管理するクラス
* @author 山内 悠佑
* @date 2022/07/07
* @details Unityの実行中にResouceファイルを経由せずに画像の変更を行うクラスに対して画像を提供するクラス
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @brief 実行中の画像を管理するクラス
* @details Unityの実行中にResouceファイルを経由せずに画像の変更を行うクラスに対して画像を提供するクラス
*/
public class TextureManager : MonoBehaviour
{
    //! TextureManagerが管理する画像のList//
    [SerializeField]
    List<Texture2D> textureList = new List<Texture2D>();

    /**
    * @fn public Texture2D GetTexture(in int _no)
    * @param[in] int(_no) 取得したい画像の番号
    * @return Texture2D 取得する画像のクラス、失敗したときにはnullが入る。
    * @details 管理している画像クラスを取得する
    */
    public Texture2D GetTexture(in int _no)
    {
        if (_no >= textureList.Count) return null;

        return textureList[_no];
    }

    /**
    * @fn public void ClearTexture()
    * @details 保持している全ての画像を削除する
    */
    public void ClearTexture()
    {
        textureList.Clear();
    }

    /**
    * @fn public void RemoveTexture(in int _no)
    * @param[in] int(_no) 削除したい画像の番号
    * @details 保持している対象の画像を削除する
    */
    public void RemoveTexture(in int _no)
    {
        if (_no >= textureList.Count) return;
        textureList.RemoveAt(_no);
    }

    /**
    * @fn public void AddTexture(Texture2D _tex)
    * @param[in] Texture2D(_tex) 登録する画像クラス
    * @details 新しい画像を追加で保持する。
    */
    public void AddTexture(in Texture2D _tex)
    {
        if (_tex == null) return;
        if (_tex.GetRawTextureData() == null) return;

        textureList.Add(_tex);
    }
}
