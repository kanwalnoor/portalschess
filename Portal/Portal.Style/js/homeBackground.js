import React from "react";

class HomeBackground extends React.Component {
    render() {

        const bgstyle = {
            backgroundImage: url("/portal-bg-potential.jpg"),
            width: "100%"
        };

        return (
        <div style={bgstyle}></div>
        );
    }
}

ReactDOM.render(<HomeBackground />, document.getElementById('home-background'));