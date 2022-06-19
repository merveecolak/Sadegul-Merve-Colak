import React from 'react'

function User() {
    //Destructing
    // const {name,bolum,maas}=this.props
  return (
    
    <div>
        {/* <form>
            <input type="text" />
            <button>Gönder</button>
        </form> */}
        {/* <h3>{props.title}</h3> */}
        <ul>
            <li>isim:{this.props.name}</li>
            <li>bolum:{this.props.bolum}</li>
            <li>maas:{this.props.maas}</li>
        </ul>
    </div>

    
  )
}

export default User