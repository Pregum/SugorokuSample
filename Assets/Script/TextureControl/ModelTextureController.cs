/**
* @file ModelTextureController.cs
* @brief オブジェクトの画像を変えるクラス
* @author 山内 悠佑
* @date 2022/07/07
* @details TextureManagerを経由してMaterialを持つオブジェクトの画像を変えるクラス
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @brief オブジェクトの画像を変えるクラス
* @details Materialを持つオブジェクトの画像をTextureManagerに登録されている画像に変えるクラス
*/
public class ModelTextureController : MonoBehaviour
{
    //! ModelTextureControllerが操作するMaterialを持つオブジェクト//
    [SerializeField]
    Renderer render = null;

    //! Shaderへ渡す時に利用するShader側の画像を入れる変数名//
    [SerializeField]
    string textureName = "_MainTex";

    //! 画像を取得するときに参照するTextureManagerオブジェクト//
    [SerializeField]
    TextureManager manager = null;

    /**
    * @fn public void SetTexture(in int _no)
    * @param[in] int(_no) 利用する画像の番号
    * @details TextureManagerから対象の画像を取得して、Materialにセットする。
    */
    public void SetTexture(in int _no)
    {
        if (manager == null) return;
        if (render == null) return;

        Texture2D tex = manager.GetTexture(_no);

        if (tex == null) return;

        render.material.SetTexture(textureName,tex);
    }

    /**
    * @fn public void SetRenderObject(in Renderer _render)
    * @param[in] Renderer(_render) 操作するMaterialを持つオブジェクト
    * @details 操作対象となるMaterialを持つRenderオブジェクトを実行中に変更する。
    */
    public void SetRenderObject(in Renderer _render)
    {
        if (_render == null) return;

        render = _render;
    }

    /**
    * @fn public void SetTextureManager(in TextureManager _manager)
    * @param[in] TextureManager(_manager) 参照をしに行くTextureManagerオブジェクト
    * @details 参照しに行くTextureManagerを実行中に変更する。
    */
    public void SetTextureManager(in TextureManager _manager)
    {
        if (_manager == null) return;

        manager = _manager;
    }


}
